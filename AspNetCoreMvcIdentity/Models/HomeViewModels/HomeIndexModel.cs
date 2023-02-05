using AspNetCoreMvcIdentity.Models.ForumViewModels;
using AspNetCoreMvcIdentity.Models.PostViewModels;
using System.Collections.Generic;

namespace AspNetCoreMvcIdentity.Models.HomeViewModels
{
    public class HomeIndexModel
    {
        public string SearchQuery { get; set; }
        public IEnumerable<PostListingModel> LatestPosts { get; set; }
        public IEnumerable<PostListingModel> PopularPosts { get; set; }
        public IEnumerable<ForumListingModel> Forums { get; set; }
    }
}
