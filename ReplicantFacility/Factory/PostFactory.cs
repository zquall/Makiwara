using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class PostFactory
    {
        private static PostService _postService;

        public PostFactory()
        {
            _postService = _postService ?? new PostService();
        }

        // Search
        public PostResponse SearchPost(PostRequest request)
        {
            return _postService.SearchPost(request);
        }

        // Get
        public PostResponse GetPost(PostRequest request)
        {
            return _postService.GetPost(request);
        }

        // Save
        public PostResponse SavePost(PostRequest request)
        {
            return _postService.SavePost(request);
        }
    }
}
