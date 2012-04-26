using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class PostRequest
    {
        public int PostId { get; set; }
        public string SearchPostQuery { get; set; }
        public PostDto Post { get; set; }
    }
}
