using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using WebAppForum.Data;

namespace WebAppForum
{
    public class ApplicationUserService : IApplicationUser
    {
        private readonly ApplicationDbContext _context;
        public ApplicationUserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<IdentityUser> GetAll()
        {
            return _context.ApplicationUsers;
        }

        public IdentityUser GetById(string id)
        {
            return GetAll().FirstOrDefault(
                user => user.Id == id);
        }
    }
}
