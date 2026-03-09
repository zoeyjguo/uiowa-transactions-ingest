public class AppContext : DbContext
{
    public DbSet<TransactionRecord> Transactions { get; set; }
    public DbSet<TransactionAudit> Audits { get; set; }

    // TODO: put sql server
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("");
    }
}