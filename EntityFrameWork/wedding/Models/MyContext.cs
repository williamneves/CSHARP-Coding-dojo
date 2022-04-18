using Microsoft.EntityFrameworkCore;

namespace Wedding.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<WeddingModel> Weddings { get; set; }
        public DbSet<Guest> Guests { get; set; }
    }
}