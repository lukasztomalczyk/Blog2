using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("DbInMemory");
           // optionsBuilder.UseSqlServer("server=localhost;user=SA;password=Kleopatra2017@@;database=Blog;trusted_connection=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostDbConfig());
            modelBuilder.ApplyConfiguration(new UserDbConfig());
        }
    }
}