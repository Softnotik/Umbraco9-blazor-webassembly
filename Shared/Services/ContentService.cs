using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Shared.Models;

namespace WebApplication1.Shared.Services
{
    public class ContentService : IContentService
    {
        protected HttpClient client;
        protected JsonSerializerOptions defaultSerializer;

        public ContentService()
        {
            defaultSerializer = new JsonSerializerOptions(JsonSerializerDefaults.Web);

            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44393/api/");
        }

        public async Task<Root> GetRoot()
        {
            var response = await client.GetAsync("content/GetRoot").ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<Root>(content, defaultSerializer);
        }

        public async Task<Root> GetMenu()
        {
            var response = await client.GetAsync("content").ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<Root>(content, defaultSerializer);
        }
    }
}
