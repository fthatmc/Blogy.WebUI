using Blogy.BusinessLayer.Abstract;
using Blogy.Dto.Layer.CommentDto;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
	public class CommentController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly ICommentService _commentService;

		public CommentController(UserManager<AppUser> userManager, ICommentService commentService)
		{
			_userManager = userManager;
			_commentService = commentService;
		}
		[HttpPost]
		public async Task<IActionResult> CreateComment(CommentDto comment)
		{
			var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);

			_commentService.TInsert(new Comment()
			{
				AppUserID = currentUser.Id,
				ArticleID = comment.ArticleId,
				NameSurname = comment.Name,
				Content = comment.Content,
				CommentDate = DateTime.Now,
				Status = false,

			});

			return RedirectToAction("BlogDetail", "Blog", new { @id = comment.ArticleId });
		}
	}
}
