using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumApi.Api.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumApi.Forum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        private readonly ApiContext _context;

        public ForumController(ApiContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Forum>>> Get()
        {
            var forums = await _context.Forums.ToArrayAsync();
            var response = forums.Select(forum => new
            {
                forum.Id,
                forum.Title,
                forum.Author
            });
            return Ok(response);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "id";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}