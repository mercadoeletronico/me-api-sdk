using System.Collections.Generic;

namespace ME.Sdk.Library.Api.v1.DecisionTable.Request
{
    public class CreateDecisionTableRequest
    {
        public string TableName { get; set; }
        public List<TableRow> TableRows { get; set; } = new List<TableRow>();
    }

    public class TableRow
    {
        public string ColumnName { get; set; }
        public string Value { get; set; }

        public TableRow(string columnName, string value)
        {
            ColumnName = columnName;
            Value = value;
        }
    }
}
