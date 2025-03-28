namespace ME.Sdk.Library.Api.v1.PreRequest.Request
{
public class RejectPreRequestItemRequest
{
    public int ItemNumber { get; set; }
    public string CustomerDeliveryLocation { get; set; }
    public string CustomerDeliveryLocationId { get; set; }
    public string ExpectedDate { get; set; }
    public List<RejectPreRequestItemCostObjectRequest> CostObjects { get; set; }
}
