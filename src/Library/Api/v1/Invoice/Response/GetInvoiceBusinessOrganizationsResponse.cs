namespace ME.Sdk.Library.Api.v1.Invoice.Response
{
    public class GetInvoiceBusinessOrganizationsResponse
    {
#if NET6_0_OR_GREATER
        public string? Code { get; set; }
        public string? Description { get; set; }
#else
        public string Code { get; set; }
        public string Description { get; set; }
#endif
    }
}
