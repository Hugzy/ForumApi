using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumApi.Api.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumApi.Thread.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThreadController : ControllerBase
    {
        private readonly ApiContext _context;

        public ThreadController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Thread>>> Get()
        {
            var threads = await _context.Threads.ToArrayAsync();
            var response = threads.Select(thread => new
            {
                thread.Id,
                thread.Title,
                //thread.Author.Name
            });
            return Ok(response);
        }
    }
}