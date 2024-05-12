using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Areas.Writer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Dashboard/")]
    public class DashboardController : Controller
	{
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;
        private readonly ICommentService _commentService;
        private readonly ICategoryService _categoryService;

        public DashboardController(UserManager<AppUser> userManager, IArticleService articleService, ICommentService commentService, ICategoryService categoryService)
        {
            _userManager = userManager;
            _articleService = articleService;
            _commentService = commentService;
            _categoryService = categoryService;
        }

        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
		{
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.BlogCount = _articleService.TGetListAll(user.Id).Count();
            ViewBag.CommentCount = _commentService.TGetListAll(user.Id).Count();

            var articles = _articleService.TGetListAll(user.Id);
            ViewBag.LastArticle = articles.First().Title;

            var comment = _commentService.TGetListAll(user.Id);
            ViewBag.LastComment = comment.Last().NameSurname;

            return View();
        }
    }
}





