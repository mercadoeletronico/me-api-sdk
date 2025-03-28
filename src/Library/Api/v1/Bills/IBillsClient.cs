using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
﻿using ME.Sdk.Library.Api.v1.Bills.Request;
using ME.Sdk.Library.Api.v1.Bills.Response;

namespace ME.Sdk.Library.Api.v1.Bills
{
    public interface IBillsClient
    {
#if NET6_0_OR_GREATER
        Task<BulkInsertAccountsPayableResponse> BulkCreateAccountsPayableAsync(BulkCreateAccountsPayableRequest request, string? correlationId, CancellationToken cancellationToken);
#else
        Task<BulkInsertAccountsPayableResponse> BulkCreateAccountsPayableAsync(BulkCreateAccountsPayableRequest request, string correlationId, CancellationToken cancellationToken);
#endif
    }
}
