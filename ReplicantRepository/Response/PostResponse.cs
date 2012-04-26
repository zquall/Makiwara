using System.Collections.Generic;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class PostResponse
    {
        public int PostId { get; set; }
        public PostDto Post { get; set; }
        public List<PostDto> PostList { get; set; }
    }
}
