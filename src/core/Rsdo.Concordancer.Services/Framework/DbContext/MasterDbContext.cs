using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Interfaces;

namespace Rsdo.Concordancer.Services.Framework.DbContext;

public class MasterDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    private readonly IConnectionStringProvider connectionStringProvider;

    public MasterDbContext(IConnectionStringProvider connectionStringProvider)
    {
        this.connectionStringProvider = connectionStringProvider;
    }

    public DbSet<Corpus> Corpus { get; set; }

    public DbSet<LemmaFormPair> LemmaFormPair { get; set; }

    public DbSet<Msd> Msd { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseNpgsql(connectionStringProvider.GetMasterConnectionString()).UseLowerCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Corpus>().HasKey(e => e.AutoId);
        modelBuilder.Entity<LemmaFormPair>().HasKey(e => e.AutoId);
        modelBuilder.Entity<Msd>().HasKey(e => e.AutoId);
    }
}