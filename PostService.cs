using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace aspweb
{
    public class PostService
    {
        private static readonly HttpClient HttpClient = new HttpClient();
        
        public async Task<Post> GetPostAsync(int id)
        {
            var response = await HttpClient
                .GetAsync($"https://jsonplaceholder.typicode.com/posts/{ id.ToString() }");

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("Error!");
                return default;
            }

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Post>(content); 
            
            return result;
        }
    }
}