using System.Collections.Generic;

namespace ME.Sdk.Library.Api.v1.Ledger.Request
{
    public class CreateLedgerRequest
    {
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public bool IsBlocked { get; set; }
    public bool IsDeactivated { get; set; }
    public bool? AreAllBusinessOrganizationsIncluded { get; set; }
    public bool? AreAllCostCentersIncluded { get; set; }
    public bool? AreAllServiceOrdersIncluded { get; set; }
    public List<CreateLedgerBusinessOrganizationRequest>? BusinessOrganizations { get; set; }
    public List<CreateLedgerCostCenterRequest>? CostCenters { get; set; }
    public List<CreateLedgerCostCenterRequest>? ServiceOrders { get; set; }
}
}
