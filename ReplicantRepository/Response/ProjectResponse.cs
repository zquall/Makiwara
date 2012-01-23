using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;

namespace ReplicantRepository.Response
{
    public class ProjectResponse
    {
        public ProjectData Project { get; set; }
        public List<ProjectData> ProjectList { get; set; }
    }

    

}
