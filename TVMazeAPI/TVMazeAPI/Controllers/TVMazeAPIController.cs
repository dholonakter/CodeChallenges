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

        //[HttpGet]
        //public async Task<IActionResult> TVMazeShowsAPI ()
        //{
        //   // TVMaze tVMaze = new TVMaze();
        //    var httpClient = _httpClientFactory.CreateClient("TVmazeAPI");
        //    var url_endppoint = $"https://api.tvmaze.com/shows";
        //    var respone= await httpClient.GetAsync(url_endppoint);
        //    if (respone.IsSuccessStatusCode) 
        //    { 
        //        var content=await respone.Content.ReadAsStringAsync();
        //        var jsonObject = JsonConvert.DeserializeObject<TVMazeShow>(content);
        //       // var jsoncontent = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

        //        var responseShows= new List<TVMazeShow>();
        //        foreach (var item in jsonObject)
        //        {

        //            var castinfo = $"https://api.tvmaze.com/shows/{jsonObject.ID}/cast";
        //            var castresponse = await httpClient.GetAsync(url_endppoint);

        //            if (castresponse.IsSuccessStatusCode)
        //            {
        //                var castContent = await castresponse.Content.ReadAsStringAsync();
        //                var castList = JsonConvert.DeserializeObject<List<Person>>(castContent);
        //                //var jsoncontent1 = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
        //                var sortedCast = castList.OrderByDescending(c => DateTime.Parse(c.Birthday)).ToList();
        //                responseShows.Add(new TVMazeShow
        //                {
        //                    ID = item.ID,
        //                    Name = item.Name,
        //                    Cast = sortedCast
        //                });


        //            }

        //        }
        //        return Ok(responseShows);


        //    else
        //    {
        //        return StatusCode((int)respone.StatusCode, "error recieveing data from TVMazeAPI");
        //    }

        //}

        [HttpGet]
        public async Task<IActionResult> TVMazeShowsAPI()
        {
            var httpClient = _httpClientFactory.CreateClient("TVmazeAPI");
            var url_endpoint = $"https://api.tvmaze.com/shows";
            var response = await httpClient.GetAsync(url_endpoint);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                // Deserialize content into a list of TVMazeShow
                var jsonObject = JsonConvert.DeserializeObject<List<TVMazeShow>>(content);

                var responseShows = new List<TVMazeShow>();

                foreach (var item in jsonObject)
                {
                    // Fetch cast information for each show
                    var castinfo = $"https://api.tvmaze.com/shows/{item.ID}/cast";
                    var castresponse = await httpClient.GetAsync(castinfo);

                    if (castresponse.IsSuccessStatusCode)
                    {
                        var castContent = await castresponse.Content.ReadAsStringAsync();
                        var castList = JsonConvert.DeserializeObject<List<CastInfo>>(castContent).Select(c=>c.Person).ToList();

                        responseShows.Add(new TVMazeShow
                        {
                            ID = item.ID,
                            Name = item.Name,
                            Cast = castList
                        });
                    }
                }

                return Ok(responseShows);
            }
            else
            {
                return StatusCode((int)response.StatusCode, "Error receiving data from TVMazeAPI");
            }
        }



        //[HttpGet("showid")]
        //public async Task<IActionResult> TVMazeCast(int showID)
        //{
        //    // TVMaze tVMaze = new TVMaze();
        //    var httpClient = _httpClientFactory.CreateClient("TVmazeAPI");
        //    var url_endppoint = $"https://api.tvmaze.com/shows/{showID}/cast";
        //    var respone = await httpClient.GetAsync(url_endppoint);
        //    if (respone.IsSuccessStatusCode)
        //    {
        //        var content = await respone.Content.ReadAsStringAsync();
        //        var jsonObject = JsonConvert.DeserializeObject<dynamic>(content);
        //        var jsoncontent = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

        //        return Ok(jsoncontent);
        //    }
        //    else
        //    {
        //        return StatusCode((int)respone.StatusCode, "error recieveing data from TVMazeAPI");
        //    }

        //}
        //[HttpGet("showCast")]
        //public async Task<IActionResult> TVMazeShowCast(int showID)
        //{
        //    return Ok();

        //}

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
