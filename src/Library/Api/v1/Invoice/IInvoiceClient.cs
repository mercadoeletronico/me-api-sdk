using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
﻿using ME.Sdk.Library.Api.v1.Invoice.Request;
using ME.Sdk.Library.Api.v1.Invoice.Response;

namespace ME.Sdk.Library.Api.v1.Invoice
{
    public interface IInvoiceClient
    {
        Task<GetInvoiceResponse> GetInvoiceAsync(GetInvoiceRequest request, CancellationToken cancellationToken);
        Task<IList<GetInvoiceItemsResponse>> GetInvoiceItemsAsync(GetInvoiceItemsRequest request, CancellationToken cancellationToken);
        Task<IList<GetInvoiceAttributesResponse>> GetInvoiceAttributesAsync(GetInvoiceAttributesRequest request, CancellationToken cancellationToken);
        Task<IList<GetInvoiceBusinessOrganizationsResponse>> GetInvoiceBusinessOrganizationsAsync(GetInvoiceBusinessOrganizationsRequest request, CancellationToken cancellationToken);
    }
}
