using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/SocialMedia")]
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var value = _socialMediaService.TGetListAll();
            return View(value);
        }

        [Route("DeleteSocialMedia/{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            _socialMediaService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("CreateSocialMedia")]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        [Route("CreateSocialMedia")]
        public IActionResult CreateSocialMedia(SocialMedia media)
        {
            _socialMediaService.TInsert(media);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("UpdateSocialMedia/{id}")]
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = _socialMediaService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        [Route("UpdateSocialMedia/{id}")]
        public IActionResult UpdateSocialMedia(SocialMedia media)
        {
            _socialMediaService.TUpdate(media);
            return RedirectToAction("Index");
        }
    }
}
