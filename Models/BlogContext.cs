using Microsoft.EntityFrameworkCore;

namespace BlogApi.Models 
{
    public class BlogContext : DbContext 
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(a => a.JoinTimestamp)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Blog>()
                .Property(b => b.CreatedTimestamp)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Post>()
                .Property(bi => bi.PostedTimestamp)
                .HasDefaultValueSql("getdate()");
        }

        public BlogContext(DbContextOptions<BlogContext> options) 
        : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}