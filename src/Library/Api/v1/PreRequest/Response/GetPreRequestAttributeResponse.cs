using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Api.v1.PreRequest.Response
    {
    public class GetPreRequestAttributeResponse
    {
    public int ItemNumber { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
    public string Description { get; set; }
}
}
