using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarMessageComponentPartial : ViewComponent
    {
        private readonly ISendMessageService _messageService;

        public _LayoutNavbarMessageComponentPartial(ISendMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.MessageCount = _messageService.TGetListAll().Count();
            var value = _messageService.TGetListAll();
            return View(value);
        }
    }
}
