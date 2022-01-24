using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppForum.Data;
using WebAppForum.Models;

namespace WebAppForum
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _context;
        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Add(Post post)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Post GetById(int id)
        {
            return _context.Posts.Where(post => post.Id == id)
                .Include(post => post.User)
                .Include(post => post.Replies).ThenInclude(reply => reply.User)
                .Include(post => post.Forum)
                .First();
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            return _context.Forums
                .Where(forum => forum.Id == id)
                .First().Posts;
        }
    }
}
