namespace ME.Sdk.Library.Api.v1.DecisionTable.Request;

public class CreateDecisionTableRequest
{
    public string TableName { get; set; }
    public List<TableRow> TableRows { get; set; } = new();
}

public record TableRow(string ColumnName, string Value);