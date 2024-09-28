using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TVMazeAPI.Data;
using TVMazeAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TVMazeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TVMazeAPIController : ControllerBase
    {
        private readonly TVMazeAPIContext _context;
        //here i am thinking to add private fields

        public TVMazeAPIController(TVMazeAPIContext context)
        {
            _context = context;
        }

        /// <summary>
        /// How to do pagination in list and then order by desc
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet("shows")]
        public async Task<IActionResult> GetShows()
        {
            var shows=await _context.Shows.Include(s=>s.Cast).ToListAsync();
            return Ok(shows);
        }


   



}
}
