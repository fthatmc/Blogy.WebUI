using Blogy.BusinessLayer.Abstract;
using Blogy.Dto.Layer.ArticleDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Blogy.WebUI.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailGetOtherBlogPostByWriterComponentPartial : ViewComponent
    {
       private readonly IArticleService _articleService;

        public _BlogDetailGetOtherBlogPostByWriterComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {

            //var values = _articleService.TCurrent3Article(id);
            //return View(values);

            var value = _articleService.TCurrent3Article(id);
            var result = value.Select(x => new ResultLast3CurrentArticlesOfWriter()
            {
                ArticleId = x.ArticleId,
                ImageURL = x.CoverImageUrl,
                Date = x.CreateDate,
                Title = x.Title,
            }).ToList();
            return View(result);
        }
    }
}
