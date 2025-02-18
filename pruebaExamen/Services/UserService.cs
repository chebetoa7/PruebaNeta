using pruebaExamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pruebaExamen.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;

        public UserService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<UserModel>> GetUsersAsync()
        {
            var url = "https://jsonplaceholder.typicode.com/users";
            var response = await _httpClient.GetStringAsync(url);
            var users = JsonSerializer.Deserialize<List<UserModel>>(response);
            return users;
        }

     
    }
}
