using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Api.v1.PreRequest.Request
    {
    public class RejectPreRequestItemRequest
    {
    public int ItemNumber { get; set; }
    public string CustomerDeliveryLocation { get; set; }
    public string CustomerDeliveryLocationId { get; set; }
    public string ExpectedDate { get; set; }
    public List<RejectPreRequestItemCostObjectRequest> CostObjects { get; set; }
}
}
