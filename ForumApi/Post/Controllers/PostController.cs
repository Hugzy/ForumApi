using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumApi.Api.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumApi.Post.Controllers
{
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly ApiContext _context;
        public PostController(ApiContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Models.Post>>> Get()
        {
            var posts = await _context.Posts.ToArrayAsync<Models.Post>();
            var response = posts.Select(p => new
            {
                id = p.Id,
                title = p.Title,
                content = p.Content
                
            });
            return Ok(response);
        }
    }
}