using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
﻿namespace ME.Sdk.Library.Api.v1.Ledger.Response
    {
    public class GetAllLedgerResponse
        {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsDeactivated { get; set; }
    }
}
