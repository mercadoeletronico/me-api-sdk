namespace ME.Sdk.Library.Api.v1.Ledger.Request
{
    public class UpdateLedgerRequest
{
#if NET6_0_OR_GREATER
    public string? Description { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsBlocked { get; set; }
    public bool? IsDeactivated { get; set; }
    public bool? AreAllBusinessOrganizationsIncluded { get; set; }
    public bool? AreAllCostCentersIncluded { get; set; }
    public bool? AreAllServiceOrdersIncluded { get; set; }
    public List<UpdateLedgerBusinessOrganizationRequest>? BusinessOrganizations { get; set; }
    public List<UpdateLedgerCostCenterRequest>? CostCenters { get; set; }
    public List<UpdateLedgerServiceOrderRequest>? ServiceOrders { get; set; }
#else
    public string Description { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsBlocked { get; set; }
    public bool? IsDeactivated { get; set; }
    public bool? AreAllBusinessOrganizationsIncluded { get; set; }
    public bool? AreAllCostCentersIncluded { get; set; }
    public bool? AreAllServiceOrdersIncluded { get; set; }
    public List<UpdateLedgerBusinessOrganizationRequest> BusinessOrganizations { get; set; }
    public List<UpdateLedgerCostCenterRequest> CostCenters { get; set; }
    public List<UpdateLedgerServiceOrderRequest> ServiceOrders { get; set; }
#endif
}
