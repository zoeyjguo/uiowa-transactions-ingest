public class TransactionsContext : DbContext
{   
    public int TransactionId { get; set; }
    public string CardNumber { get; set; }
    public string LocationCode { get; set; }
    public string ProductName { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }
    public TransactionStatus Status {get; set; } 

    // TODO: put sql server
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("");
    }
}