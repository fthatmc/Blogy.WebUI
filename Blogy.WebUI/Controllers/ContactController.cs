using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using Blogy.BusinessLayer.ValidationRules.SendMessageValidation;
using Blogy.Dto.Layer.SendMessageDto;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace Blogy.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly ISendMessageService _messageService;

        public ContactController(ISendMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Index(SendMessageDto message)
		{
			 
			SendMessageValidation validator = new SendMessageValidation();
			ValidationResult validationResult = validator.Validate(message);

			if (validationResult.IsValid)
			{
				_messageService.TInsert(new SendMessage()
				{
					NameSurname = message.NameSurname,
					Email = message.Email,
					Subject = message.Subject,
					Message = message.Message,
				});
				return RedirectToAction("Index","Contact");
			}
			else
			{
				foreach (var item in validationResult.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View(message);

		}
	}
}
