using ForumApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumApi.Api.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }
 
        public DbSet<SimpleUser> Users { get; set; }
 
        public DbSet<Post.Models.Post> Posts { get; set; }
        
        public DbSet<Content> Contents { get; set; }
        
        public DbSet<Forum.Models.Forum> Forums { get; set; }
    }
}