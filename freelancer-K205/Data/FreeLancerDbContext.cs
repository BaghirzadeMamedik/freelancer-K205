using freelancer_K205.Models;
using Microsoft.EntityFrameworkCore;

namespace freelancer_K205.Data
{
    public class FreeLancerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FreeLancerDB; Trusted_Connection=True;MultipleActiveResultSets=true");
        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Masthead> Mastheads { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
