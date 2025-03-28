using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
﻿namespace ME.Sdk.Library.Api.v1.Bills.Request
    {
    public class BulkCreateAccountsPayableRequest
    {
    public Stream FileStream { get; set; }
    public string FileName { get; set; }
}
}
