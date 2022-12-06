using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Interfaces;

namespace Rsdo.Concordancer.Services.Framework.DbContext;

public class CorpusDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    private readonly IConnectionStringProvider connectionStringProvider;

    public CorpusDbContext(IConnectionStringProvider connectionStringProvider)
    {
        this.connectionStringProvider = connectionStringProvider;
    }

    public DbSet<Paragraph> Paragraph { get; set; }

    public DbSet<Sentence> Sentence { get; set; }

    public DbSet<Term> Term { get; set; }

    public DbSet<TermList> TermList { get; set; }

    public DbSet<Text> Text { get; set; }

    public DbSet<Token> Token { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseNpgsql(connectionStringProvider.GetCorpusConnectionString()).UseLowerCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Paragraph>().HasKey(e => e.AutoId);
        modelBuilder.Entity<Sentence>().HasKey(e => e.AutoId);
        modelBuilder.Entity<Term>().HasKey(e => e.AutoId);
        modelBuilder.Entity<TermList>().HasKey(e => e.AutoId);
        modelBuilder.Entity<Text>().HasKey(e => e.AutoId);
        modelBuilder.Entity<Token>().HasKey(e => e.AutoId);
    }
}