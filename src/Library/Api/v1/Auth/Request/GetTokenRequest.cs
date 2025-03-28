using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Api.v1.Auth.Request
    {
    public class GetTokenRequest
        {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
