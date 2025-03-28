using ME.Sdk.Library.Api.v1.Auth;
using ME.Sdk.Library.Api.v1.Bills;
using ME.Sdk.Library.Api.v1.DecisionTable;
using ME.Sdk.Library.Api.v1.Invoice;
using ME.Sdk.Library.Api.v1.Ledger;
using ME.Sdk.Library.Api.v1.PreOrder;
using ME.Sdk.Library.Api.v1.PreRequest;
using ME.Sdk.Library.Api.v1.User;

namespace ME.Sdk.Library
{
    /// <summary>
    /// Provides clients for accessing Mercado Eletrônico APIs. 
/// For more information, see the <see href="https://developer.me.com.br/">documentation</see>.
/// </summary>
public interface IMEApiClient
{
    /// <summary>
    /// Client for managing authentication and token generation.
    /// <see href="https://developer.me.com.br/api/meweb-auth-api_v1_auth_tokens_post">Auth API documentation</see>.
    /// </summary>
    public IAuthClient AuthClient { get; }
    
    /// <summary>
    /// Client for managing bills and accounts payable.
    /// <see href="https://developer.me.com.br/api/me-integration-bills-api_v1_bills_accounts-payable_post">Bills API documentation</see>.
    /// </summary>
    public IBillsClient BillsClient { get; }
    
    /// <summary>
    /// Client for handling pre-orders, including fetching and creating pre-orders.
    /// <see href="https://developer.me.com.br/api/me-integration-pre-order_v1_pre-orders_$id_get">Pre-Order API documentation</see>.
    /// </summary>
    public IPreOrderClient PreOrderClient { get; }
    
    /// <summary>
    /// Client for decision table management.
    /// <see href="https://developer.me.com.br/api/me-integration-decision-table-api_v1_decision-table_post">Decision Table API documentation</see>.
    /// </summary>
    public IDecisionTableClient DecisionTableClient { get; }
    
    /// <summary>
    /// Client for managing pre-requests, allowing you to fetch and manage purchase pre-requests.
    /// <see href="https://developer.me.com.br/api/me-integration-request_v1_requests_pre-requests_$preRequestId_get">Pre-Request API documentation</see>.
    /// </summary>
    public IPreRequestClient PreRequestClient { get; }
    
    /// <summary>
    /// Client for invoice management.
    /// <see href="https://developer.me.com.br/api/meweb-invoice-api_v1_invoices_$invoiceId_get">Invoice API documentation</see>.
    /// </summary>
    public IInvoiceClient InvoiceClient { get; }
    
    /// <summary>
    /// Client for user management, allowing you to query and manage users.
    /// <see href="https://developer.me.com.br/api/me-integration-user_v1_users_get">User API documentation</see>.
    /// </summary>
    public IUserClient UserClient { get; }
    
    /// <summary>
    /// Client for managing ledgers.
    /// <see href="https://developer.me.com.br/api/me-integration-ledger-api_v1_ledgers_get">Ledger API documentation</see>.
    /// </summary>
    public ILedgerClient LedgerClient { get; }
}
