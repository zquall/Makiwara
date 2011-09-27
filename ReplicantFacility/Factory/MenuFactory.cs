using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;

namespace ReplicantFacility.Factory
{
    class MenuFactory
    {
        private static MenuService _MenuService;
        public MenuFactory()
        {
            _MenuService = _MenuService ?? new MenuService();
        }

    }
}
