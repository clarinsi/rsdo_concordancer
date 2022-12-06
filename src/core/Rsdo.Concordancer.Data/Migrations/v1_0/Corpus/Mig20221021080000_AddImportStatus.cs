using FluentMigrator;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Data.Framework;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Data.Migrations.v1_0.Corpus;

[CorpusDb]
[Migration(20221021080000)]
public class Mig20221021080000_AddTextAndTermListStatus : ForwardOnlyMigration
{
    public override void Up()
    {
        // Text
        Alter.Table(nameof(Text)).AddColumn(nameof(Text.Status)).AsByte().Nullable();
        Execute.Sql($"UPDATE {nameof(Text)} SET {nameof(Text.Status)} = {(int)ImportStatus.Active};");
        Alter.Table(nameof(Text)).AlterColumn(nameof(Text.Status)).AsByte().NotNullable();

        // TermList
        Alter.Table(nameof(TermList)).AddColumn(nameof(TermList.Status)).AsByte().Nullable();
        Execute.Sql($"UPDATE {nameof(TermList)} SET {nameof(TermList.Status)} = {(int)ImportStatus.Active};");
        Alter.Table(nameof(TermList)).AlterColumn(nameof(TermList.Status)).AsByte().NotNullable();
    }
}