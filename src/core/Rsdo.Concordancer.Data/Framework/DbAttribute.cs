using FluentMigrator;
using Rsdo.Concordancer.Core.Interfaces;

namespace Rsdo.Concordancer.Data.Framework;

public abstract class DbAttribute : TagsAttribute
{
    protected DbAttribute(MigrationTag migrationTag)
        : base(migrationTag.ToString())
    {
    }
}

public class CorpusDbAttribute : DbAttribute
{
    public CorpusDbAttribute()
        : base(MigrationTag.Corpus)
    {
    }
}

public class MasterDbAttribute : DbAttribute
{
    public MasterDbAttribute()
        : base(MigrationTag.Master)
    {
    }
}