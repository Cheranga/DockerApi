using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestContainerApi.DTO;

namespace TestContainerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TriviaController : ControllerBase
    {
        [HttpGet("{number}")]
        public async Task<IActionResult> Get(int number)
        {
            var httpClient = new HttpClient();
            var httpResponse = await httpClient.GetAsync($"http://numbersapi.com/{number}?json");
            var content = await httpResponse.Content.ReadAsStringAsync();

            var triviaResponse = JsonConvert.DeserializeObject<TriviaResponse>(content);

            return Ok(triviaResponse);
        }
    }
}