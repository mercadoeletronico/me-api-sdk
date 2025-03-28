using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
﻿namespace ME.Sdk.Library.Api.v1.Ledger.Request
    {
    public class DeleteLedgerRequest
        {
        public bool? AreAllBusinessOrganizationsIncluded { get; set; }
        public bool? AreAllCostCentersIncluded { get; set; }
        public bool? AreAllServiceOrdersIncluded { get; set; }
        public List<DeleteLedgerBusinessOrganizationRequest>? BusinessOrganizations { get; set; }
        public List<DeleteLedgerCostCenterRequest>? CostCenters { get; set; }
        public List<DeleteLedgerServiceOrderRequest>? ServiceOrders { get; set; }
    }
}
