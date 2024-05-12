using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailOtherPostsComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogDetailOtherPostsComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _articleService.TGetLast4Article();
            return View(value);
        }
    }
}
