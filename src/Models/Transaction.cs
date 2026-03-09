public class Transaction
{   
    public int TransactionId { get; set; }
    public string CardNumber { get; set; }
    public string LocationCode { get; set; }
    public string ProductName { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }
    public TransactionStatus Status {get; set; }
    public List<TransactionAudit> Audits { get; set; }
} 

public enum TransactionStatus
{
    Active,
    Revoked,
    Finalized
}