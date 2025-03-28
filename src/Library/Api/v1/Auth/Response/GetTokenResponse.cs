using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Api.v1.Auth.Response
    {
    public class GetTokenResponse
        {
        public string AccessToken { get; set; }
        public int ExpiresIn { get; set; }
    }
}
