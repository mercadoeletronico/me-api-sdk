using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Api.v1.PreRequest.Request
{
    public class RejectPreRequestItemCostObjectRequest
    {
        public int Index { get; set; }
        public string Quantity { get; set; }
        public string PercentageAmount { get; set; }
        public string Value { get; set; }
        public string LedgerAccount { get; set; }
        public string CostCenter { get; set; }
        public string WbsElement { get; set; }
    }
}
