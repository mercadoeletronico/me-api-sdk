using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ME.Sdk.Library.Api.v1.PreOrder.Request;
using ME.Sdk.Library.Api.v1.PreOrder.Response;

namespace ME.Sdk.Library.Api.v1.PreOrder
    {
    public interface IPreOrderClient
        {
        Task<GetPreOrderResponse> GetPreOrderAsync(GetPreOrderRequest request, CancellationToken cancellationToken);
    }
}
