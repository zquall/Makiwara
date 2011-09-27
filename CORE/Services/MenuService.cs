using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;

namespace CORE.Services
{
    public class MenuService
    {
        public MenuService()
        {
            
        }

        public MenuResponse getNavigationItemList(string groupCode)
        {
            var response = new MenuResponse();
            var tmpGroupId = getNavigationGroupByCode(groupCode).NavigationGroup.Id;
            foreach (var item in Olympus._Nerv.Latches.Where(x => x.LatchParent == tmpGroupId).ToList())
	        {
		        NavigationItem tmpNavItem = new NavigationItem();
                tmpNavItem.Code = item.Code;
                tmpNavItem.Caption = item.Caption;
                response.NavigationItemList.Add(tmpNavItem);
	        }             
            return response;
        }

        public MenuResponse getNavigationGroupByCode(string groupCode)
        {
            var response = new MenuResponse();
            var tmpMenuGroup = Olympus._Nerv.Latches.Where(x => x.Code == groupCode).FirstOrDefault();   
            if (tmpMenuGroup != null)
            {
                response.NavigationGroup.Id = tmpMenuGroup.Id;
            }
            return response;
        }
    }
}
