using Microsoft.EntityFrameworkCore;

namespace todolist.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=PELIN\\SQLEXPRESS;Database=Corelist;Trusted_Connection=True;MultipleActiveResultSets=true;");

        }
        public DbSet<datatodo> datados { get; set; }
    }
}
