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
 
        public DbSet<Post> Posts { get; set; }
    }
}