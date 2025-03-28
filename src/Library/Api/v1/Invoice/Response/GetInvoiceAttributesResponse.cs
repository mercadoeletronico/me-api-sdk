namespace ME.Sdk.Library.Api.v1.Invoice.Response
{
public class GetInvoiceAttributesResponse
{
    public string Name { get; set; }
#if NET6_0_OR_GREATER
    public string? Value { get; set; }
    public string? Description { get; set; }
#else
    public string Value { get; set; }
    public string Description { get; set; }
#endif
}
}
