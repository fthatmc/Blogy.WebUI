using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccesLayer.Context;
using Blogy.Dto.Layer.ContactDto;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
	public class _ContactComponentPartial : ViewComponent
	{
		private readonly IContactService _contactService;

		public _ContactComponentPartial(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IViewComponentResult Invoke()
		{
			var value = _contactService.TGetListAll();
			return View(value);
		}
	}
}
