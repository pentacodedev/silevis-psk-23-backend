using HackathonApi.Entities;
using System.Diagnostics.Contracts;

namespace HackathonApi.Services
{
    public class UsosService
    {
        private HttpClient _client = new HttpClient();

        public UsosService()
        {
        }


        public async Task<User?> GetUserByEmailAsync(string email)
        {
            /*
            var result = await _client.GetAsync($"http://hackathon23-mockapi-env.eba-qfrnjqkt.eu-central-1.elasticbeanstalk.com/user/{email}");
            return await result.Content.ReadFromJsonAsync<User>();
            */

            /* override */
            return new User {
                FirstName = "Test",
                LastName = "Debug",
                StudentNumber = "1111",
                StudentProgrammes = new List<StudentProgramme>(),
                Email = email,
            };
        }
        
    }
}
