using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
﻿namespace ME.Sdk.Library.Api.v1.Ledger.Request
{
    public class UpdateLedgerServiceOrderRequest
    {
        public string ClientCodeId { get; set; }
        public string Category { get; set; }
    }
}
