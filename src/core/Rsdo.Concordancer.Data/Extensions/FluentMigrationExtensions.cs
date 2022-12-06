using FluentMigrator;
using FluentMigrator.Builders.Create.Table;
using Rsdo.Concordancer.Core.Entities;

namespace Rsdo.Concordancer.Data.Extensions;

public static class FluentMigrationExtensions
{
    public static ICreateTableColumnOptionOrWithColumnSyntax WithEntity(this ICreateTableWithColumnSyntax tableWithColumnSyntax)
    {
        return tableWithColumnSyntax.WithColumn(nameof(Entity.AutoId))
            .AsInt64()
            .PrimaryKey()
            .Identity()
            .NotNullable()
            .WithColumn(nameof(Entity.CreatedDate))
            .AsDateTime2()
            .NotNullable()
            .WithDefault(SystemMethods.CurrentDateTime)
            .WithColumn(nameof(Entity.Id))
            .AsGuid()
            .NotNullable()
            .WithColumn(nameof(Entity.ModifiedDate))
            .AsDateTime2()
            .NotNullable()
            .WithDefault(SystemMethods.CurrentDateTime);
    }
}