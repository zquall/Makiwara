using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    public class MenuResponse
    {
        public NavigationGroup NavigationGroup { get; set; }
        public List<NavigationItem> NavigationItemList { get; set; }
    }
    public class NavigationItem
    {
        public string Code { get; set; }
        public string Caption { get; set; }
    }
    public class NavigationGroup
    {
        public int? Id { get; set; }
    }
}
