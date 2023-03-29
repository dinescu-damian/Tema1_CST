global using Microsoft.EntityFrameworkCore;
using Tema1_CST.DataLayer.Entities;

namespace Tema1_CST.DataLayer
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=Blog;Trusted_Connection=True;TrustServerCertificate=True");
        }

        // DbSets
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Article> Articles { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;

    }
}
