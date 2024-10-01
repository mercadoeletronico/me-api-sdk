using FluentAssertions;

using ME.Sdk.Library.Api.v1.User.Request;
using ME.Sdk.Library.Common.Exceptions;

using NUnit.Framework;

namespace ME.Sdk.Library.IntegrationTests.v1.User;

public class GetUserTest : BaseIntegrationTest
{
    [Test]
    public void GetUser_NotFound()
    {
        // Arrange
        var request = new GetUserRequest { UserId = 43};

        // Act
        var exception = Assert.ThrowsAsync<NotFoundException>(async () =>
        {
            await Client.UserClient.GetUserAsync(request, CancellationToken.None);
        });

        // Assert
        exception.Should().NotBeNull();
        exception!.Message.Should().Contain("User with UserId: 43 not found");
    }
    
    [Test]
    public async Task GetUser_200Ok()
    {
        // Arrange
        var request = new GetUserRequest {UserId = 4088176};

        // Act
        var order = await Client.UserClient.GetUserAsync(request, CancellationToken.None);

        // Assert
        order.Should().NotBeNull();
        order.Id.Should().Be(4088176);
        order.Login.Should().Be("HIPSTER_E2E");
    }
}