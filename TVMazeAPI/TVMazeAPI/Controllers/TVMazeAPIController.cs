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
        //here i am thinking to add private fields

        public TVMazeAPIController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        //scrapes the TVMaze API for show and cast informa=on; 

        // first get the TV shows all info

        //second the cast with showID
        //third combine and return the result

        [HttpGet]
        public async Task<IActionResult> TVMazeShows ()
        {
           // TVMaze tVMaze = new TVMaze();
            var httpClient = _httpClientFactory.CreateClient("TVmazeAPI");
            var url_endppoint = $"https://api.tvmaze.com/shows";
            var respone= await httpClient.GetAsync(url_endppoint);
            if (respone.IsSuccessStatusCode) 
            { 
                var content=await respone.Content.ReadAsStringAsync();
                var jsonObject = JsonConvert.DeserializeObject<dynamic>(content);
                var jsoncontent= JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                //Console.WriteLine( $"show{jsonObject.ID} name{jsonObject.Name}");
                //if (jsonObject.Embedded != null && jsonObject.Embedded.Casts != null)
                //{
                //    foreach (var item in jsonObject.Embedded.Casts)
                //    {
                //        var person = item.Persons;
                //        Console.WriteLine(person);
                //    }
                //}

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

        [HttpGet("showid")]
        public async Task<IActionResult> TVMazeCast(int showID)
        {
            // TVMaze tVMaze = new TVMaze();
            var httpClient = _httpClientFactory.CreateClient("TVmazeAPI");
            var url_endppoint = $"https://api.tvmaze.com/shows/{showID}/cast";
            var respone = await httpClient.GetAsync(url_endppoint);
            if (respone.IsSuccessStatusCode)
            {
                var content = await respone.Content.ReadAsStringAsync();
                var jsonObject = JsonConvert.DeserializeObject<dynamic>(content);
                var jsoncontent = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

                return Ok(jsoncontent);
            }
            else
            {
                return StatusCode((int)respone.StatusCode, "error recieveing data from TVMazeAPI");
            }

        }
        [HttpGet("showCast")]
        public async Task<IActionResult> TVMazeShowCast(int showID)
        {
            return Ok();

        }



    }
}
