namespace ME.Sdk.Library.Api.v1.PreRequest.Request
    {
    public class RejectPreRequestRequest
    {
    public string PreRequestId { get; set; }
    public string Title { get; set; }
    public string CustomerDeliveryLocationId { get; set; }
    public List<RejectPreRequestBusinessOrganizationRequest> BusinessOrganizations { get; set; }
    public List<RejectPreRequestItemRequest> Items { get; set; }
}
}
}
