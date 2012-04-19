using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using ReplicantRepository.DataTransferObjects;

namespace shellCloud.Models
{

    public class ProjectInformModel
    {
        public List<ProjectInformDto> PendingProjectInforms { get; set; }
    }

}
