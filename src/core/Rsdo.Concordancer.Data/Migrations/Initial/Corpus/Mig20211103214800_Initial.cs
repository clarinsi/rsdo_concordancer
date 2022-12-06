using System.Data;
using FluentMigrator;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Data.Extensions;
using Rsdo.Concordancer.Data.Framework;

namespace Rsdo.Concordancer.Data.Migrations.Initial.Corpus;

[CorpusDb]
[Migration(20211103214800)]
public class Mig20211103214800_Initial : ForwardOnlyMigration
{
    public override void Up()
    {
        // Text
        Create.Table(nameof(Text))
            .WithEntity()
            .WithColumn(nameof(Text.Author))
            .AsString(255)
            .Nullable()
            .WithColumn(nameof(Text.SourceFile))
            .AsString(255)
            .NotNullable()
            .WithColumn(nameof(Text.Title))
            .AsString(255)
            .Nullable()
            .WithColumn(nameof(Text.Year))
            .AsInt16()
            .Nullable();

        Create.Index().OnTable(nameof(Text)).OnColumn(nameof(Text.Id)).Ascending().WithOptions().Unique();

        // Paragraph
        Create.Table(nameof(Paragraph))
            .WithEntity()
            .WithColumn(nameof(Paragraph.RecordOrder))
            .AsInt32()
            .NotNullable()
            .WithColumn(nameof(Paragraph.TextAutoId))
            .AsInt64()
            .NotNullable()
            .ForeignKey(nameof(Text), nameof(Text.AutoId))
            .OnDelete(Rule.Cascade);

        Create.Index().OnTable(nameof(Paragraph)).OnColumn(nameof(Paragraph.Id)).Ascending().WithOptions().Unique();
        Create.Index().OnTable(nameof(Paragraph)).OnColumn(nameof(Paragraph.TextAutoId));

        // Sentence
        Create.Table(nameof(Sentence))
            .WithEntity()
            .WithColumn(nameof(Sentence.ParagraphAutoId))
            .AsInt64()
            .NotNullable()
            .ForeignKey(nameof(Paragraph), nameof(Paragraph.AutoId))
            .OnDelete(Rule.Cascade)
            .WithColumn(nameof(Sentence.RecordOrder))
            .AsInt32()
            .NotNullable();

        Create.Index().OnTable(nameof(Sentence)).OnColumn(nameof(Sentence.Id)).Ascending().WithOptions().Unique();
        Create.Index().OnTable(nameof(Sentence)).OnColumn(nameof(Sentence.ParagraphAutoId));

        // Token
        Create.Table(nameof(Token))
            .WithEntity()
            .WithColumn(nameof(Token.Form))
            .AsString(400)
            .Nullable()
            .WithColumn(nameof(Token.Lemma))
            .AsString(400)
            .Nullable()
            .WithColumn(nameof(Token.Msd))
            .AsString(20)
            .Nullable()
            .WithColumn(nameof(Token.RecordOrder))
            .AsInt32()
            .NotNullable()
            .WithColumn(nameof(Token.SentenceAutoId))
            .AsInt64()
            .NotNullable()
            .ForeignKey(nameof(Sentence), nameof(Sentence.AutoId))
            .OnDelete(Rule.Cascade)
            .WithColumn(nameof(Token.TokenOrder))
            .AsInt32()
            .NotNullable()
            .WithColumn(nameof(Token.Type))
            .AsByte()
            .NotNullable();

        Create.Index().OnTable(nameof(Token)).OnColumn(nameof(Token.Id)).Ascending().WithOptions().Unique();
        Create.Index().OnTable(nameof(Token)).OnColumn(nameof(Token.SentenceAutoId)).Ascending().OnColumn(nameof(Token.TokenOrder));

        // TermList
        Create.Table(nameof(TermList)).WithEntity().WithColumn(nameof(Text.SourceFile)).AsString(255).NotNullable();

        // Term
        Create.Table(nameof(Term))
            .WithEntity()
            .WithColumn(nameof(Term.Form))
            .AsString(400)
            .NotNullable()
            .WithColumn(nameof(Term.Frequency))
            .AsInt32()
            .NotNullable()
            .WithColumn(nameof(Term.Lemma))
            .AsString(400)
            .NotNullable()
            .WithColumn(nameof(Term.Msd))
            .AsString(100)
            .NotNullable()
            .WithColumn(nameof(Term.TermListAutoId))
            .AsInt64()
            .NotNullable()
            .ForeignKey(nameof(TermList), nameof(TermList.AutoId))
            .OnDelete(Rule.Cascade)
            .WithColumn(nameof(Term.Weight))
            .AsDecimal(16, 15)
            .NotNullable();

        Create.Index().OnTable(nameof(Term)).OnColumn(nameof(Term.Id)).Ascending().WithOptions().Unique();
        Create.Index().OnTable(nameof(Term)).OnColumn(nameof(Term.TermListAutoId)).Ascending();
    }
}