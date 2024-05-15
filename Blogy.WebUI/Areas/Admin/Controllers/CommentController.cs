using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Comment")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var value = _commentService.TGetCommentsWithArticleAndUser();
            return View(value);
        }

        [Route("ChangeToStatusTrue/{id}")]
        public IActionResult ChangeToStatusTrue(int id)
        {
            _commentService.TChangeToStatusTrue(id);
            return RedirectToAction("Index");
        }

        [Route("ChangeToStatusFalse/{id}")]
        public IActionResult ChangeToStatusFalse(int id)
        {
            _commentService.TChangeToStatusFalse(id);
            return RedirectToAction("Index");
        }
    }
}
