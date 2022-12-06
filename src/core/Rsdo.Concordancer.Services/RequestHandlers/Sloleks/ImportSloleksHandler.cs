using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Sloleks;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.Services.Framework.BulkLoaders;

namespace Rsdo.Concordancer.Services.RequestHandlers.Sloleks;

public class ImportSloleksHandler : IRequestHandler<ImportSloleks, ExecutionResult>
{
    private readonly IBulkLoader bulkLoader;

    public ImportSloleksHandler(IBulkLoader bulkLoader)
    {
        this.bulkLoader = bulkLoader;
    }

    public async Task<ExecutionResult> Handle(ImportSloleks request, CancellationToken cancellationToken)
    {
        var sourceFile = request.SourceFile;
        if (!File.Exists(sourceFile))
        {
            throw new FileNotFoundException($"File {sourceFile} not found!", sourceFile);
        }

        var items = Import(sourceFile);
        await SaveData(items, cancellationToken);
        return new ExecutionResult();
    }

    private static string GetFeature(XElement element, string featName)
    {
        return element?.Elements("feat").SingleOrDefault(e => e.Attribute("att")?.Value == featName)?.Attribute("val")?.Value;
    }

    private static Dictionary<string, HashSet<string>> Import(string sourceFile)
    {
        var items = new Dictionary<string, HashSet<string>>(StringComparer.Ordinal);
        using var stream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
        using var xmlReader = XmlReader.Create(stream);
        while (xmlReader.Read())
        {
            if (xmlReader.NodeType != XmlNodeType.Element || xmlReader.LocalName != "LexicalEntry")
            {
                continue;
            }

            using var entryReader = xmlReader.ReadSubtree();
            ImportEntry(entryReader, items);
        }

        return items;
    }

    private static void ImportEntry(XmlReader entryReader, Dictionary<string, HashSet<string>> items)
    {
        var entryEl = XElement.Load(entryReader);

        // Skip if multiword
        var partOfSpeech = GetFeature(entryEl, "besedna_vrsta");
        if (!string.IsNullOrEmpty(partOfSpeech) && partOfSpeech == "večbesedna_enota")
        {
            return;
        }

        // Get lemma
        var lemmaEl = entryEl.Element("Lemma");
        var lemma = GetFeature(lemmaEl, "zapis_oblike");

        // Add lemma to items
        if (!items.ContainsKey(lemma))
        {
            items.Add(lemma, new HashSet<string>(StringComparer.Ordinal));
        }

        // Get forms
        foreach (var wordFormEl in entryEl.Elements("WordForm"))
        {
            foreach (var representationEl in wordFormEl.Elements("FormRepresentation"))
            {
                var form = GetFeature(representationEl, "zapis_oblike");
                if (string.IsNullOrEmpty(form))
                {
                    continue;
                }

                if (!items[lemma].Contains(form))
                {
                    items[lemma].Add(form);
                }
            }
        }
    }

    private async Task SaveData(Dictionary<string, HashSet<string>> items, CancellationToken cancellationToken)
    {
        var pairs = from lemma in items.Keys
            from form in items[lemma]
            select new LemmaFormPair()
            {
                Lemma = lemma,
                Form = form,
            }.ApplyCreateValues();

        foreach (var batch in pairs.Chunk(50000))
        {
            await bulkLoader.InsertEntities(batch.ToList(), cancellationToken);
        }
    }
}