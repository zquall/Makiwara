using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class ResourceTypeRequest
    {
        public string SearchResourceTypeQuery { get; set; }
        //public ResourceTypeData ResourceType { get; set; }
        public ResourceTypeDto ResourceType { get; set; }
    }
}
