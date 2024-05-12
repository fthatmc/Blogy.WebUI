using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
    public class _LayoutSideBarLanguageComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }
    }
}
