using Microsoft.EntityFrameworkCore;

namespace UserDashboardApp.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasOne(p => p.AuthorUser)
                .WithMany(b => b.AuthorUserMessages);
        }
    }
}