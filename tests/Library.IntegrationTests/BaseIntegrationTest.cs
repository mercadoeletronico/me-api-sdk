using NUnit.Framework;

namespace ME.Sdk.Library.IntegrationTests;

public abstract class BaseIntegrationTest
{
    protected IMEApiClient Client { get; private set; }

    [OneTimeSetUp]
    public void Setup()
    {
        Client = new MEApiClient(new MEApiSettings
        {
            BaseAddress = "https://trunk.api.mercadoe.com",
            ClientId = "G56WFG85J7K5DOMW",
            ClientSecret = "bDHO1TWdLGGln4pWvxw26OtCHpV6Yw1Q"
        });
    }
}