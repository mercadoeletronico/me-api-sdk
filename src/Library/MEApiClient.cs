using ME.Sdk.Library.Api;
using ME.Sdk.Library.Api.v1.Auth;
using ME.Sdk.Library.Api.v1.Bills;
using ME.Sdk.Library.Api.v1.DecisionTable;
using ME.Sdk.Library.Api.v1.Invoice;
using ME.Sdk.Library.Api.v1.Ledger;
using ME.Sdk.Library.Api.v1.PreOrder;
using ME.Sdk.Library.Api.v1.PreRequest;
using ME.Sdk.Library.Api.v1.User;
using ME.Sdk.Library.Common.Http;

namespace ME.Sdk.Library
    {

    public class MEApiClient : IMEApiClient
    {
    public IAuthClient AuthClient { get; }
    public IPreOrderClient PreOrderClient { get; }
    public IDecisionTableClient DecisionTableClient { get; }
    public IPreRequestClient PreRequestClient { get; }
    public IBillsClient BillsClient { get; }
    public IInvoiceClient InvoiceClient { get; set; }
    public IUserClient UserClient { get; }
    public ILedgerClient LedgerClient { get;}
}

    public MEApiClient(MEApiSettings settings)
        {
        var httpHandler = new HttpHandler(settings);
        AuthClient = new AuthClient(settings, httpHandler);
        var apiClient = new ApiHttpClient(httpHandler, AuthClient);
        PreOrderClient = new PreOrderClient(apiClient);
        DecisionTableClient = new DecisionTableClient(apiClient);
        PreRequestClient = new PreRequestClient(apiClient);
        BillsClient = new BillsClient(apiClient);
        InvoiceClient = new InvoiceClient(apiClient);
        UserClient = new UserClient(apiClient);
        LedgerClient = new LedgerClient(apiClient);
    }
}
}
