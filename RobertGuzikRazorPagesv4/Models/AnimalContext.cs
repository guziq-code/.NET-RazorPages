using Microsoft.EntityFrameworkCore; 


namespace RobertGuzikRazorPagesv4.Models
{
    public class AnimalContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AnimalContext");
        }
        }
    }

