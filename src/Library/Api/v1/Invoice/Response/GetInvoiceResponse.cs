namespace ME.Sdk.Library.Api.v1.Invoice.Response;

public class GetInvoiceResponse
{
    public string? SerialNumber { get; set; }
    public string? InvoiceNumber { get; set; }
    public DateTime? IssueDate { get; set; }
    public double? TotalDue { get; set; }
    public double? NetPrice { get; set; }
    public double? InvoiceCharging { get; set; }
    public string? ClientSupplierId { get; set; }
    public string? Currency { get; set; }
    public DateTime? CreationDate { get; set; }
    public string? UserLogin { get; set; }
    public DateTime? DueDate { get; set; }
}