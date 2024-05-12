using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccesLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailCategoryListComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public _BlogDetailCategoryListComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {

            var values = _categoryService.TGetCategoriesAndCount();
            return View(values);
        }
    }
}
