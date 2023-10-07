using Microsoft.EntityFrameworkCore;

namespace db_and_news.Models
{
    public class ADbContext : DbContext
    {
        public ADbContext () { }

        public ADbContext(DbContextOptions<ADbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlServer("Server=192.168.226.130; Database=db_news;User=sa;Password=Colorado2023; TrustServerCertificate=True;");
    }
}
