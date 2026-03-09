public class TransactionAudit
{
    public int Id { get; set; }
    public string TransactionId { get; set; }
    public string FieldName { get; set; }
    public string OldValue { get; set; }
    public string NewValue { get; set; }
}