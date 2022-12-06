using FluentMigrator.Runner.Generators.Postgres;
using FluentMigrator.Runner.Processors.Postgres;

namespace Rsdo.Concordancer.Data.Framework;

public class NoQuoteQuoter : PostgresQuoter
{
    public NoQuoteQuoter(PostgresOptions options)
        : base(options)
    {
    }

    protected override bool ShouldQuote(string name)
    {
        return false;
    }
}