
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Biblioteka.Api;
using Biblioteka.Infrastructure.Commands.Users;
using Biblioteka.Infrastructure.DTO;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace Biblioteka.Tests.EndToEnd.Controllers
{
    public class UsersControllerTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public UsersControllerTests()
        {
            _server = new TestServer(new WebHostBuilder()
                        .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task given_valid_email_user_should_exist()
        {
            var email = "user1@email.com";
            var user = await GetUserAsync(email);
            user.Email.ShouldBeEquivalentTo(email);
        }

        [Fact]
        public async Task given_invalid_email_user_should_not_exist()
        {
            var email = "user@email.com";
            var response = await _client.GetAsync($"users/{email}");
            response.StatusCode.ShouldBeEquivalentTo(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task given_unique_email_user_should_be_created()
        {
            var request = new CreateUser
            {
                Email = "test@email.com",
                Username = "test",
                Password = "secret"
            };
            var payload = GetPayload(request);
            var response = await _client.PostAsync("users", payload);
            response.StatusCode.ShouldBeEquivalentTo(HttpStatusCode.Created);
            response.Headers.Location.ToString().ShouldBeEquivalentTo($"users/{request.Email}");

            var user  = await GetUserAsync(request.Email);
            user.Email.ShouldBeEquivalentTo(request.Email);
            
        }

        private async Task<UserDto> GetUserAsync(string email)
        {
             var response = await _client.GetAsync($"users/{email}");             //pobiera user-a o podanym emailu
            response.EnsureSuccessStatusCode();                                   //upewnia sie ze dostalismy kod 200 

            var responseString = await response.Content.ReadAsStringAsync();      //przypisuje obiekt w postaci stringa 
            return JsonConvert.DeserializeObject<UserDto>(responseString);        //Deserializuje Json-a na UserDto
            
        }

        private static StringContent GetPayload(object data)
        {
            var json = JsonConvert.SerializeObject(data);

            return new StringContent(json, Encoding.UTF8, "application/json");
        }
        
    }
}