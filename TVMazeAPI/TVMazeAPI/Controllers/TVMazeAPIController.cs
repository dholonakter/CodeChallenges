using Microsoft.AspNetCore.Mvc;
using TVMazeAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TVMazeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TVMazeAPIController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private string base_address = "https://api.tvmaze.com/";
        public TVMazeAPIController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public ActionResult<Task> TVMazeShowsCast (int id, string[]cast)
        {
           // TVMaze tVMaze = new TVMaze();
            var httpClient = _httpClientFactory.CreateClient("TVmazeAPI");
            var url_endppoint = $"{base_address}/shows/{id}/{cast}";
            return Ok();

        }
       

    }
}
