using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogApi.Models;

namespace BlogApi.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly BlogContext _context;

        public PostController(BlogContext context)
        {
            _context = context;
        }

        // GET: api/Post
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        // GET: api/Post/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetPost(long id)
        {
            var Post = await _context.Posts.FindAsync(id);

            if (Post == null)
            {
                return NotFound();
            }

            return Post;
        }

        // GET: api/Post/ByBlog/5
        [HttpGet("ByBlog/{id}")]
        public async Task<ActionResult<IEnumerable<Post>>> GetPostsByBlog(long id)
        {
            var blog = await _context.Blogs.FindAsync(id);

            if (blog == null)
            {
                return NotFound();
            }

            return blog.Posts;
        }

        // GET: api/Post/ByAuthor/5
        [HttpGet("ByAuthor/{id}")]
        public async Task<ActionResult<IEnumerable<Post>>> GetPostsByAuthor(long id)
        {
            var author = await _context.Authors.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }

            return author.Posts;
        }

        // PUT: api/Post/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost(long id, Post Post)
        {
            if (id != Post.Id)
            {
                return BadRequest();
            }

            _context.Entry(Post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Post
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(Post Post)
        {
            _context.Posts.Add(Post);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPost", new { id = Post.Id }, Post);
        }

        // DELETE: api/Post/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(long id)
        {
            var Post = await _context.Posts.FindAsync(id);
            if (Post == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(Post);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostExists(long id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
    }
}
