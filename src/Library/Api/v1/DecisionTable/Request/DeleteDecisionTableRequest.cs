namespace ME.Sdk.Library.Api.v1.DecisionTable.Request;

public class DeleteDecisionTableRequest
{
    public string TableName { get; set; }
    public List<TableRow> TableRows { get; set; } = new();
}