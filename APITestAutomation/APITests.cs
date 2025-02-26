using APITestAutomation.APIutility;
using APITestAutomation.Models;
using Xunit;

namespace APITestAutomation
{
    public class APITests
    {
        private const string BaseUrl = "https://dummyjson.com";

        [Fact]
        public void APIInvalidLoginTest()
        {
            // Arrange
            var apiUtility = new APIUtility(BaseUrl);
            var loginRequest = new LoginRequest
            {
                Username = "user",
                Password = "invalidCreds"
            };

            // Act
            var response = apiUtility.Post<LoginResponse, LoginRequest>("/auth/login", loginRequest);

            // Assert
            Assert.NotNull(response);
            Assert.Equal("Username and password required", response.Message);
        }
    }
}