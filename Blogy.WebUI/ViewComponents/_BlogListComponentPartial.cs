﻿using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
    public class _BlogListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            
            var value = _articleService.TGetArticleStatusTrue();
            return View(value);
        }
    }
}
