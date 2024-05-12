using Blogy.BusinessLayer.Abstract;
using Blogy.Dto.Layer.ArticleDtos;
using Blogy.Dto.Layer.SearchDto;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IArticleService _articleService;

        public BlogController(IArticleService articleService)
        {
            _articleService = articleService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogList(string search)
        {
			if (!string.IsNullOrEmpty(search))
			{

				var value = _articleService.TGetArticleFilterList(search);
				ViewBag.Search = search;
				return View(value);
			}
			else
			{
				var values = _articleService.TGetArticleWithWriter();
				return View(values);

			}
		}

		public IActionResult BlogDetail(int id)
		{
            ViewBag.i = id;
			return View();
		}
	}
}
