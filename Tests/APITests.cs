using Xunit;
using Models;

public class APITests
{
    [Fact]
    public void Test_InvalidLogin()
    {
        // Arrange
        var apiObj = new APIUtility("https://vpic.nhtsa.dot.gov");
        var request = new LoginRequest
        {
            Username = "user",
            Password = "invalidCreds"
        };

        // Act
        var response = apiObj.Post<LoginResponse, LoginRequest>("api/vehicles/getallmakes", request);

        // Assert
        Assert.Equal("invalid login credential", response.Message);
    }
}