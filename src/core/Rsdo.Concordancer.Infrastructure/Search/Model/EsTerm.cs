using System;

namespace Rsdo.Concordancer.Infrastructure.Search.Model;

public class EsTerm
{
    public Guid Id { get; set; }

    public int Frequency { get; set; }

    public EsToken Token { get; set; }

    public EsToken TokenRight1 { get; set; }

    public EsToken TokenRight2 { get; set; }

    public EsToken TokenRight3 { get; set; }

    public EsToken TokenRight4 { get; set; }

    public decimal Weight { get; set; }
}