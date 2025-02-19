using ME.Sdk.Library.Api.v1.User.Models;

namespace ME.Sdk.Library.Api.v1.User.Request;

public class CreateUserRequest
{
    public string Name { get; set; }
    public string Login { get; set; }
    public string Contact { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Profile { get; set; }
    public string Permission { get; set; }
    public string Role { get; set; }
    public string IntegrationTag { get; set; }
    public bool? IsDeactivated { get; set; }
    public int? LanguageId { get; set; }
    public IList<BusinessOrganization> BusinessOrganizations { get; set; }
    public IList<CostCenter> CostCenters { get; set; }
    public IList<PurchasingGroup> PurchasingGroups { get; set; }
    public IList<SupplierGroup> SupplierGroups { get; set; }
}
