using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Contact")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var value = _contactService.TGetListAll();
            return View(value);
        }

        [HttpGet]
        [Route("UpdateContact/{id}")]
        public IActionResult UpdateContact(int id)
        {
            var values = _contactService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        [Route("UpdateContact/{id}")]
        public IActionResult UpdateContact(Contact contact)
        {
            _contactService.TUpdate(contact);
            return RedirectToAction("CategoryList");
        }
    }
}
