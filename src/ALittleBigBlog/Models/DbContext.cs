using Microsoft.EntityFrameworkCore;

namespace ALittleBigBlog.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
        {

        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
