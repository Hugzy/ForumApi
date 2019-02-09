using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumApi.Api.Context;
using ForumApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumApi.Controllers
{
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly ApiContext _context;
        public PostController(ApiContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Post>>> Get()
        {
            var posts = await _context.Posts.ToArrayAsync();
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