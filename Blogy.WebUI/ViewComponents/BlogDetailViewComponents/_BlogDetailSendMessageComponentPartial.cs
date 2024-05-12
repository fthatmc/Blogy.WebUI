using Blogy.BusinessLayer.Abstract;
using Blogy.Dto.Layer.ArticleDtos;
using Blogy.Dto.Layer.CommentDto;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailSendMessageComponentPartial : ViewComponent
    {
               
		public IViewComponentResult Invoke(int id)
        {
			var values = new CommentDto()
			{
				ArticleId = id,
			};

			return View(values);
        }

	}
}
