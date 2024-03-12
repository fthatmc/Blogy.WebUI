using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.ValidationRules.ArticleValidation
{
    public class CreateArticleValidation :AbstractValidator<Article>
    {
        public CreateArticleValidation() 
        {
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("lütfen makale için bir kategori seçin");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Makale için başlık girin");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen Makale için açıklama girin");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen başlığa en az 5 karakter veri girişi yapın");
            RuleFor(x => x.Title).MaximumLength(100).WithMessage("Lütfen başlığa en fazla 100 karakter veri girişi yapın");
        }
    }
}
