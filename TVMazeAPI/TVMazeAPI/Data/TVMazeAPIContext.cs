using Microsoft.EntityFrameworkCore;

namespace TVMazeAPI.Data
{
    public class TVMazeAPIContext:DbContext
    {
        public TVMazeAPIContext(DbContextOptions<TVMazeAPIContext> options):base(options) { }
        
            
        
    }
}
