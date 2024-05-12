using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{

    [Area("Writer")]
    [Route("/Writer/Statistic")]
    public class StatisticController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;
        private readonly ICommentService _commentService;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;
        private readonly INotificationService _notificationService;
        private readonly IWriterService _writerService;

        public StatisticController(UserManager<AppUser> userManager, IArticleService articleService, ICommentService commentService, ICategoryService categoryService, ITagService tagService, INotificationService notificationService, IWriterService writerService)
        {
            _userManager = userManager;
            _articleService = articleService;
            _commentService = commentService;
            _categoryService = categoryService;
            _tagService = tagService;
            _notificationService = notificationService;
            _writerService = writerService;
        }

        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.BlogCount = _articleService.TGetListAll(user.Id).Count();
            ViewBag.FirstBlog = _articleService.TGetListAll(user.Id).Select(x=>x.Title).FirstOrDefault();
            ViewBag.LastBlog = _articleService.TGetListAll(user.Id).OrderBy(x=>x.CreateDate).Select(x=>x.Title).FirstOrDefault();
            ViewBag.CommentCount = _commentService.TGetListAll(user.Id).Count();
            ViewBag.CategoryCount = _categoryService.TGetListAll().Count();
            ViewBag.TagCount = _tagService.TGetListAll().Count();
            ViewBag.WriterCount = _writerService.TGetListAll().Count();
            ViewBag.NotificationCount = _notificationService.TGetListAll().Count();
            ViewBag.FirstComment = _commentService.TGetListAll(user.Id).Select(x => x.Content).FirstOrDefault();
            var categories = _categoryService.TGetListAll();
            ViewBag.FirstCategory = categories.First().CategoryName;
            ViewBag.lastCategory = categories.Last().CategoryName;
            var Tag = _tagService.TGetListAll();
            ViewBag.FirstTag = Tag.First().TagTitle;

            return View();
        }
    }
}
