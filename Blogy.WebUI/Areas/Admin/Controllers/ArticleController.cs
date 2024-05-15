using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccesLayer.Context;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Article")]
    public class ArticleController : Controller
    {
        BlogyContext context = new BlogyContext();
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly UserManager<AppUser> _userManager;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, UserManager<AppUser> userManager)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _userManager = userManager;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _articleService.TGetArticleWithWriter();
            return View(values);
        }

        [HttpGet]
        [Route("CreateArticle")]
        public IActionResult CreateArticle()
        {
            List<SelectListItem> values = (from x in context.Categorys.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString(),
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        [Route("CreateArticle")]
        public IActionResult CreateArticle(Article article)
        {
            _articleService.TInsert(article);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("UpdateArticle")]
        public IActionResult UpdateArticle(int id)
        {
            var value = _articleService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        [Route("UpdateArticle")]
        public IActionResult UpdateArticle(Article article)
        {
            _articleService.TUpdate(article);
            return RedirectToAction("Index");
        }

        [Route("DeleteArticle/{id}")]
        public ActionResult DeleteArticle(int id)
        {
            _articleService.TDelete(id);
            return RedirectToAction("Index");
        }

        [Route("ChangeToStatusTrue/{id}")]
        public IActionResult ChangeToStatusTrue(int id)
        {
            _articleService.TChangeToTrueArticleStatus(id);
            return RedirectToAction("Index");
        }

        [Route("ChangeToStatusFalse/{id}")]
        public IActionResult ChangeToStatusFalse(int id)
        {
            _articleService.TChangeToFalseArticleStatus(id);
            return RedirectToAction("Index");
        }


    }
}
