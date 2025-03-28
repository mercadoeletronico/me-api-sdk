using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Sdk.Library.Api.v1.DecisionTable.Response
{
#if NET6_0_OR_GREATER
    public record TableRowResponse(string ColumnName, string Value);
#else
    public class TableRowResponse
    {
        public string ColumnName { get; }
        public string Value { get; }

        public TableRowResponse(string columnName, string value)
        {
            ColumnName = columnName;
            Value = value;
        }
    }
#endif
}
}
