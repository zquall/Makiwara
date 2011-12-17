using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;

namespace ReplicantRepository.Request
{
    public class ProjectRequest
    {
        public string SearchProjectQuery { get; set; }
        public ProjectData Project { get; set; }
    }
}
