using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAppForum
{
    public interface IApplicationUser
    {
        IdentityUser GetById(string id);
        IEnumerable<IdentityUser> GetAll();
        
    }
}
