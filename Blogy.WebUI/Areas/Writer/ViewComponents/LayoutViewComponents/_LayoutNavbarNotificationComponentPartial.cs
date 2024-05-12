using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarNotificationComponentPartial : ViewComponent
    {
        private readonly INotificationService _notificationService;

        public _LayoutNavbarNotificationComponentPartial(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public  IViewComponentResult Invoke()
        {
            ViewBag.NotificationCount = _notificationService.TGetListAll().Count();
            var values = _notificationService.TLast3Notification();
            return View(values);
        }
    }
}
