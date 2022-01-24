using System.Collections.Generic;

namespace WebAppForum.Models
{
    public class ForumIndexModel
    {
        public IEnumerable<ForumListingModel> ForumList { get; set; }
    }
}
