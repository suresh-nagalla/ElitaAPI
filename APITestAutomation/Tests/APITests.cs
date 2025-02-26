using Xunit;
using APITestAutomation.APIutility;
using APITestAutomation.Models;

namespace APITestAutomation.Tests
{
    public class APITests
    {
        [Fact]
        public void Test_InvalidLogin()
        {
            // Arrange
            var apiUtility = new APIUtility("https://vpic.nhtsa.dot.gov");
            var loginRequest = new LoginRequest
            {
                Username = "user",
                Password = "invalidCreds"
            [Fact]
        public void Test_APIInvalidLogin()
        {
            // Arrange
            var apiUtility = new APIUtility("https://vpic.nhtsa.dot.gov");
            var request = new GetAllMakesRequest
            {
                Username = "user",
                Password = "invalidCreds"
            };

            // Act
            var response = apiUtility.Post<GetAllMakesResponse, GetAllMakesRequest>("api/vehicles/getallmakes", request);

            // Assert
            Assert.Equal("invalid login credential", response.Message);
        }
    };

            // Act
            var response = apiUtility.Post<LoginResponse, LoginRequest>("api/vehicles/getallmakes", loginRequest);

            // Assert
            Assert.Equal("invalid login credential", response.Message);
        [Fact]
        public void Test_APIInvalidLogin()
        {
            // Arrange
            var apiUtility = new APIUtility("https://vpic.nhtsa.dot.gov");
            var request = new GetAllMakesRequest
            {
                Username = "user",
                Password = "invalidCreds"
            };

            // Act
            var response = apiUtility.Post<GetAllMakesResponse, GetAllMakesRequest>("api/vehicles/getallmakes", request);

            // Assert
            Assert.Equal("invalid login credential", response.Message);
        }
    }
    [Fact]
        public void Test_APIInvalidLogin()
        {
            // Arrange
            var apiUtility = new APIUtility("https://vpic.nhtsa.dot.gov");
            var request = new GetAllMakesRequest
            {
                Username = "user",
                Password = "invalidCreds"
            };

            // Act
            var response = apiUtility.Post<GetAllMakesResponse, GetAllMakesRequest>("api/vehicles/getallmakes", request);

            // Assert
            Assert.Equal("invalid login credential", response.Message);
        }
    }
[Fact]
        public void Test_APIInvalidLogin()
        {
            // Arrange
            var apiUtility = new APIUtility("https://vpic.nhtsa.dot.gov");
            var request = new GetAllMakesRequest
            {
                Username = "user",
                Password = "invalidCreds"
            };

            // Act
            var response = apiUtility.Post<GetAllMakesResponse, GetAllMakesRequest>("api/vehicles/getallmakes", request);

            // Assert
            Assert.Equal("invalid login credential", response.Message);
        }
    }