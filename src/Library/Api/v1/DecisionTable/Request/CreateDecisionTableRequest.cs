namespace ME.Sdk.Library.Api.v1.DecisionTable.Request
{
    public class CreateDecisionTableRequest
{
    public string TableName { get; set; }
    public List<TableRow> TableRows { get; set; } = new();
}

#if NET6_0_OR_GREATER
    public record TableRow(string ColumnName, string Value);
#else
    public class TableRow
{
    public string ColumnName { get; }
    public string Value { get; }

    public TableRow(string columnName, string value)
    {
        ColumnName = columnName;
        Value = value;
    }
}
#endif
}
}
