using Microsoft.EntityFrameworkCore;

namespace MyVideoAPI.Models
{
    public class MyVideoApiContext : DbContext
    {
        public DbSet<VideoModel> MyVideos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("Data Source=MyVideos.db");
    }
}
