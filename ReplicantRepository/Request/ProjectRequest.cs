using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Request
{
    public class ProjectRequest
    {
        public int? ProjectId { get; set; }
        public string SearchProjectQuery { get; set; }
        public ProjectDto Project { get; set; }
    }
}
