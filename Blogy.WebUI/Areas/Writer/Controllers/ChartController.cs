using Blogy.DataAccesLayer.Context;
using Blogy.WebUI.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ChartController : Controller
    {
        BlogyContext _context = new BlogyContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chart()
        {
            var values = _context.Articles.GroupBy(x => x.CategoryId).Select(y => new ChartViewModel
            {
                name = _context.Categorys.Where(x => x.CategoryId == y.Key).Select(x => x.CategoryName).FirstOrDefault(),
                count = y.Count(),
            }).ToList();
            return Json(new { jsonlist = values });
        }
    }
}
