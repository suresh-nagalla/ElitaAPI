using Xunit;
using APITestAutomation.APIutility;
using APITestAutomation.Models;
using System.Net;

namespace APITestAutomation
{
    public class APITests
    {
        private const string BaseUrl = "https://vpic.nhtsa.dot.gov";

        [Fact]
        public void Test_API_InvalidLogin()
        {
            // Arrange
            var apiUtility = new APIUtility(BaseUrl);
            var request = new InvalidLoginRequest
            {
                Username = "user",
                Password = "invalidCreds"
            };

            // Act
            var response = apiUtility.Post<InvalidLoginResponse, InvalidLoginRequest>("api/vehicles/getallmakes", request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal("invalid login credential", response.Message);
        }
    }
}