using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailViewComponents
{
    public class _FooterLast3BlogComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _FooterLast3BlogComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _articleService.TCurrent3Article();
            return View(value);
        }
    }
}
