using FluentMigrator;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Data.Extensions;
using Rsdo.Concordancer.Data.Framework;

namespace Rsdo.Concordancer.Data.Migrations.Initial.Master;

[MasterDb]
[Migration(20211016212200)]
public class Mig20211016212200_Initial : ForwardOnlyMigration
{
    public override void Up()
    {
        // Corpus
        Create.Table(nameof(Core.Entities.Corpus))
            .WithEntity()
            .WithColumn(nameof(Core.Entities.Corpus.Description))
            .AsString(255)
            .Nullable()
            .WithColumn(nameof(Core.Entities.Corpus.Status))
            .AsByte()
            .NotNullable()
            .WithColumn(nameof(Core.Entities.Corpus.Title))
            .AsString(100)
            .NotNullable();

        // LemmaFormPair
        Create.Table(nameof(LemmaFormPair))
            .WithEntity()
            .WithColumn(nameof(LemmaFormPair.Lemma))
            .AsString(255)
            .NotNullable()
            .WithColumn(nameof(LemmaFormPair.Form))
            .AsString(255)
            .NotNullable();
        Execute.Sql($"CREATE INDEX ix_lemmaformpair_form_lower ON lemmaformpair (lower(form))");
    }
}