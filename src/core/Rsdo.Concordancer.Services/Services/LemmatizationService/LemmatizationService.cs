using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.Services.LemmatizationService;

public class LemmatizationService : ILemmatizationService
{
    private readonly MasterDbContext dbContext;

    public LemmatizationService(MasterDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<string>> GetLemmas(string form)
    {
        var lemmas = await dbContext.LemmaFormPair.Where(f => f.Form.ToLower() == form.ToLower()).Select(f => f.Lemma).Distinct().ToListAsync();
        if (lemmas.IsNullOrEmpty())
        {
            lemmas.Add(form);
        }

        return lemmas;
    }
}