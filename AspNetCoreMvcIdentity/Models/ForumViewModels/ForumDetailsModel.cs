using AspNetCoreMvcIdentity.Models.PostViewModels;
using System.Collections.Generic;

namespace AspNetCoreMvcIdentity.Models.ForumViewModels
{
    public class ForumDetailsModel
    {
        public ForumListingModel Forum { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }
        public string SearchQuery { get; set; }
    }
}
