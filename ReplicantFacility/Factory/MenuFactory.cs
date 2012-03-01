using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class MenuFactory
    {
        private static MenuService _menuService;

        public MenuFactory()
        {
            _menuService = _menuService ?? new MenuService();
        }

        public MenuResponse GetNavigationItemList(MenuRequest request)
        {
            return _menuService.getNavigationItemsByGroupCode(request);
        }

    }
}
