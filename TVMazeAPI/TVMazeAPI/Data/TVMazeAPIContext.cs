using Microsoft.EntityFrameworkCore;
using TVMazeAPI.Model;

namespace TVMazeAPI.Data
{
    public class TVMazeAPIContext:DbContext
    {
        public TVMazeAPIContext(DbContextOptions<TVMazeAPIContext> options):base(options) { }
        
        public DbSet<TVMazeShow> Shows { get; set; }
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the relationship between TVMazeShow and Person
            modelBuilder.Entity<TVMazeShow>().HasMany(s => s.Cast).WithOne().HasForeignKey(p => p.ShowId);

            base.OnModelCreating(modelBuilder); 
        }

    }
}
