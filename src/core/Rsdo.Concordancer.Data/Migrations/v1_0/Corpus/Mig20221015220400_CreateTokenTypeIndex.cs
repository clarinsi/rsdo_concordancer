using FluentMigrator;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Data.Framework;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Data.Migrations.v1_0.Corpus;

[CorpusDb]
[Migration(20221015220400)]
public class Mig20221015220400_CreateTokenTypeIndex : ForwardOnlyMigration
{
    public override void Up()
    {
        var token = nameof(Token).ToLower();
        var type = nameof(Token.Type).ToLower();
        var word = (int)TokenType.Word;

        Execute.Sql($"CREATE INDEX ix_{token}_{type}_partial ON {token}({type}) WHERE {type} = {word}");
    }
}