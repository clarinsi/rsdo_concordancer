using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Services.Services.TokenizerService;

public abstract class BaseTokenizerService : ITokenizerService
{
    public async Task<IEnumerable<(TokenType type, string form)>> Tokenize(string query)
    {
        var xml = await GetXml(query);
        return ReadTokens(xml);
    }

    protected abstract Task<string> GetXml(string query);

    private static IEnumerable<(TokenType type, string form)> ReadTokens(string xml)
    {
        var tokens = new List<(TokenType type, string form)>();
        using TextReader textReader = new StringReader(xml);
        var readerSettings = new XmlReaderSettings
        {
            ConformanceLevel = ConformanceLevel.Fragment,
        };
        using var xmlReader = XmlReader.Create(textReader, readerSettings);
        while (xmlReader.Read())
        {
            if (xmlReader.NodeType == XmlNodeType.Element)
            {
                switch (xmlReader.LocalName)
                {
                    case "c":
                        xmlReader.Read(); // To move to text node
                        tokens.Add((TokenType.Character, xmlReader.Value));
                        break;
                    case "w":
                        xmlReader.Read(); // To move to text node
                        tokens.Add((TokenType.Word, xmlReader.Value));
                        break;
                }
            }
        }

        return tokens;
    }
}