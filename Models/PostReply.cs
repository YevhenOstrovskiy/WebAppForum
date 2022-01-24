﻿using System;
using Microsoft.AspNetCore.Identity;

namespace WebAppForum.Models
{
    public class PostReply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public virtual IdentityUser User { get; set; }
        public virtual Post Post { get; set; }
    }
}
