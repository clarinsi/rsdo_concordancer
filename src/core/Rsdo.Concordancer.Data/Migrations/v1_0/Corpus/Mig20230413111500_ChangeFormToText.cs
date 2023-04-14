using System;
using FluentMigrator;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Data.Framework;

namespace Rsdo.Concordancer.Data.Migrations.v1_0.Corpus;

[CorpusDb]
[Migration(20230413111500)]
public class Mig20230413111500_ChangeFormToText : ForwardOnlyMigration
{
    public override void Up()
    {
        // Token
        Alter.Column(nameof(Token.Form)).OnTable(nameof(Token)).AsString(int.MaxValue).Nullable();
        Alter.Column(nameof(Token.Lemma)).OnTable(nameof(Token)).AsString(int.MaxValue).Nullable();

        // Term
        Alter.Column(nameof(Term.Form)).OnTable(nameof(Term)).AsString(int.MaxValue).NotNullable();
        Alter.Column(nameof(Term.Lemma)).OnTable(nameof(Term)).AsString(int.MaxValue).NotNullable();
    }
}