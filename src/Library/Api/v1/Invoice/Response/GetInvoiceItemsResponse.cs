namespace ME.Sdk.Library.Api.v1.Invoice.Response;

public class GetInvoiceItemsResponse
{
    public int InvoiceItemId { get; set; }
    public double? Quantity { get; set; }
    public double? Price { get; set; }
    public double? TotalNetPrice { get; set; }
    public string? Description { get; set; }
}