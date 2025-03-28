using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Sdk.Library.Api.v1.DecisionTable.Response
{
    public class GetDecisionTableResponse
    {        
        public List<TableRowResponse> Rows { get; set; } = new();
    }
}
