using FiorelloBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FiorelloBack.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<HeaderSlider> HeaderSliders{ get; set; }
        public DbSet<Setting> settings { get; set; }
        public DbSet<FlowerExpert> FlowerExperts{ get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<FooterSlider> FooterSliders { get; set; }
    }
}
