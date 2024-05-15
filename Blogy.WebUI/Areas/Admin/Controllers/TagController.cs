using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Tag")]
    public class TagController : Controller
    {
        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var value = _tagService.TGetListAll();
            return View(value);
        }

        [Route("DeleteTag/{id}")]
        public IActionResult DeleteTag(int id)
        {
            _tagService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("CreateTag")]
        public IActionResult CreateTag()
        {
            return View();
        }

        [HttpPost]
        [Route("CreateTag")]
        public IActionResult CreateTag(Tag tag)
        {
            _tagService.TInsert(tag);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("UpdateTag/{id}")]
        public IActionResult UpdateTag(int id)
        {
            var values = _tagService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        [Route("UpdateTag/{id}")]
        public IActionResult UpdateTag(Tag tag)
        {
            _tagService.TUpdate(tag);
            return RedirectToAction("Index");
        }
    }
}
