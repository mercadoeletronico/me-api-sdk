namespace ME.Sdk.Library.Api.v1.PreRequest.Response
{
public class GetPreRequestResponse
{
    public string PreRequestId { get; set; }
    public string Title { get; set; }
    public string Note { get; set; }
    public string Category { get; set; }
    public int ClientDeliveryLocationId { get; set; }
    public int ClientBillingLocationId { get; set; }
    public int ClientCollectionPaymentLocationId { get; set; }
    public List<GetPreRequestAttributeResponse> Attributes { get; set; }
}
