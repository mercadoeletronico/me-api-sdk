namespace ME.Sdk.Library.Api.v1.User.Response
{
public class GetUserResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Contact { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Profile { get; set; }
    public string Permission { get; set; }
    public string Role { get; set; }
    public string IntegrationTag { get; set; }
    public bool isDeactivated { get; set; }
    public int LanguageId { get; set; }
}
}
