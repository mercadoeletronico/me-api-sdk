using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Api.v1.PreRequest.Request
{
    public class RejectPreRequestRequest
    {
        public string PreRequestId { get; set; }
        public string Title { get; set; }
        public string CustomerDeliveryLocationId { get; set; }
        public List<RejectPreRequestBusinessOrganizationRequest> BusinessOrganizations { get; set; }
        public List<RejectPreRequestItemRequest> Items { get; set; }
    }
}
