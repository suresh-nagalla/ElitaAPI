using Xunit;
using APITestAutomation.APIutility;
using APITestAutomation.Models;
using System.Net;

namespace APITestAutomation
{
    public class APITests
    {
        private const string BaseUrl = "https://vpic.nhtsa.dot.gov";
        private const string Endpoint = "api/vehicles/getallmakes";

        [Fact]
        public void API_InvalidLogin_ShouldReturnInvalidCredentialMessage()
        {
            // Arrange
            var apiUtility = new APIUtility(BaseUrl);
            var loginRequest = new LoginRequest { Username = "user", Password = "invalidCreds" };

            // Act
            var response = apiUtility.Post<LoginResponse, LoginRequest>(Endpoint, loginRequest);

            // Assert
            Assert.NotNull(response);
            Assert.Equal("invalid login credential", response.Message);
        }
    }
}