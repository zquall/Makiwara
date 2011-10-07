using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class MenuFactory
    {
        private static MenuService _MenuService;
        public MenuFactory()
        {
            _MenuService = _MenuService ?? new MenuService();
        }

        public MenuResponse getNavigationItemList(MenuRequest request)
        {
            return _MenuService.getNavigationItemsByGroupCode(request);
        }

    }
}
