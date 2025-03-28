using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
﻿namespace ME.Sdk.Library.Api.v1.User.Response
{
    public class GetAllResponse
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string IntegrationTag { get; set; }
    }
}
