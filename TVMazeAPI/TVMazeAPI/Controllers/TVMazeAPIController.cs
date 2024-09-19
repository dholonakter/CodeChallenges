using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TVMazeAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TVMazeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TVMazeAPIController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TVMazeAPIController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        //scrapes the TVMaze API for show and cast informa=on; 

        [HttpGet]
        public async Task<IActionResult> TVMazeShowsCast (int id)
        {
           // TVMaze tVMaze = new TVMaze();
            var httpClient = _httpClientFactory.CreateClient("TVmazeAPI");
            var url_endppoint = $"https://api.tvmaze.com/shows/{id}/cast";
            var respone= await httpClient.GetAsync(url_endppoint);
            if (respone.IsSuccessStatusCode) 
            { 
                var content=await respone.Content.ReadAsStringAsync();
                var jsonObject = JsonConvert.DeserializeObject(content);
                var jsoncontent= JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                return Ok(jsoncontent);
            }
            else
            {
                return StatusCode((int)respone.StatusCode, "error recieveing data from TVMazeAPI");
            }

        }
        //[HttpGet]
        //public ActionResult<Task> TVMazeShowsCast(int id, string[] cast)
        //{
        //    // TVMaze tVMaze = new TVMaze();
        //    var httpClient = _httpClientFactory.CreateClient("TVmazeAPI");
        //    var url_endppoint = $"{base_address}/shows/{id}/{cast}";
        //    return Ok();

        //}


    }
}
