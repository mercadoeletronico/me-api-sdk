using FluentAssertions;

using ME.Sdk.Library.Api.v1.PreOrder.Request;
using ME.Sdk.Library.Common.Exceptions;

using NUnit.Framework;

namespace ME.Sdk.Library.IntegrationTests.v1.PreOrder;

public class GetPreOrderTest : BaseIntegrationTest
{
    [Test]
    public void GetPreOrderTest_NotFound()
    {
        // Arrange
        var request = new GetPreOrderRequest {PreOrderId = 43};

        // Act
        var exception = Assert.ThrowsAsync<NotFoundException>(async () =>
        {
            await Client.PreOrderClient.GetPreOrderAsync(request, CancellationToken.None);
        });

        // Assert
        exception.Should().NotBeNull();
        exception!.Message.Should().Contain("PreOrder with id 43 was not found");
    }
    
    [Test]
    public async Task GetPreOrderTest_200Ok()
    {
        // Arrange
        var request = new GetPreOrderRequest {PreOrderId = 8163409};

        // Act
        var order = await Client.PreOrderClient.GetPreOrderAsync(request, CancellationToken.None);

        // Assert
        order.Should().NotBeNull();
        order.QuotationId.Should().Be(5274467);
    }
}