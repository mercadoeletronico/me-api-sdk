using FluentAssertions;

using ME.Sdk.Library.Api.v1.DecisionTable.Request;

using NUnit.Framework;

namespace ME.Sdk.Library.IntegrationTests.v1.DecisionTable;

public class CreateDecisionTableTest : BaseIntegrationTest
{
    [Test]
    public async Task CreateDecisionTable_202Accepted()
    {
        // Arrange
        var request = new CreateDecisionTableRequest {TableName = "table_name", TableRows = new List<TableRow>
        {
            new("column_a", "value a"),
            new("column_b", "value b")
        }};

        // Act
        var order = await Client.DecisionTableClient.CreateAsync(request, "internal_id", CancellationToken.None);

        // Assert
        order.Should().NotBeNull();
        order.CorrelationId.Should().Be("internal_id");
    }
}