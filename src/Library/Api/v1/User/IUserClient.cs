using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
﻿using ME.Sdk.Library.Api.v1.User.Request;
using ME.Sdk.Library.Api.v1.User.Response;

namespace ME.Sdk.Library.Api.v1.User
{
    public interface IUserClient
    {
        Task<GetUserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken);
        Task<IList<GetUserBusinessOrganizationsResponse>> GetUserBusinessOrganizationsAsync(GetUserBusinessOrganizationsRequest request, CancellationToken cancellationToken);
        Task<IList<GetAllResponse>> GetAllAsync(GetAllRequest request, CancellationToken cancellationToken);
    }
}
