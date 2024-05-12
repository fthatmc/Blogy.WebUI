using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailViewComponents
{
    public class _FooterSocialMediaComponentPartial : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _FooterSocialMediaComponentPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _socialMediaService.TGetListAll();
            return View(value);
        }
    }
}
