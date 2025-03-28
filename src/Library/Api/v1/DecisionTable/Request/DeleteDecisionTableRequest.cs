using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library.Api.v1.DecisionTable.Request
    {

    public class DeleteDecisionTableRequest
    {
    public string TableName { get; set; }
    public List<TableRow> TableRows { get; set; } = new List<TableRow>();
}
}
