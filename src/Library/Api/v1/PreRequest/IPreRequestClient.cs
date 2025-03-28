using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ME.Sdk.Library.Api.v1.PreRequest.Request;
using ME.Sdk.Library.Api.v1.PreRequest.Response;

namespace ME.Sdk.Library.Api.v1.PreRequest
{
    public interface IPreRequestClient
    {
        Task<GetPreRequestResponse> GetPreRequestAsync(GetPreRequestRequest request, CancellationToken cancellationToken);

        Task<ApprovePreRequestResponse> ApprovePreRequestAsync(ApprovePreRequestRequest request, string correlationId,
            CancellationToken cancellationToken);

        Task<RejectPreRequestResponse> RejectPreRequestAsync(RejectPreRequestRequest request, string correlationId,
            CancellationToken cancellationToken);
    }
}
