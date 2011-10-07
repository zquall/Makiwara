using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace CORE.Services
{
    public class MenuService
    {
        public MenuService()
        {
            
        }

        public MenuResponse getNavigationItemsByGroupCode(MenuRequest request)
        {
            var response = new MenuResponse();
            var navigationGroup = getNavigationGroupByCode(request);
            if (navigationGroup != null)
            {
                response.NavigationItemList = new List<NavigationItem>();
                foreach (var item in Olympus._Nerv.Latches.Where(x => x.LatchParent == navigationGroup.Id).ToList())
                {
                    NavigationItem tmpNavItem = new NavigationItem();
                    tmpNavItem.Code = item.Code;
                    tmpNavItem.Caption = item.Caption;
                    response.NavigationItemList.Add(tmpNavItem);
                }
            }                       
            return response;
        }

        public NavigationGroup getNavigationGroupByCode(MenuRequest request)
        {
            var response = new NavigationGroup();
            var tmpMenuGroup = Olympus._Nerv.Latches.Where(x => x.Code == request.NavigationGroupCode).FirstOrDefault();   
            if (tmpMenuGroup != null)
            {
                response.Id = tmpMenuGroup.Id;
            }
            return response;
        }
    }
}
