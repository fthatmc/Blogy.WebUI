using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.ValidationRules.CategoryValidation
{
    public class UpdateCategoryValidation : AbstractValidator<Category>
    {
        public UpdateCategoryValidation() 
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı En Az 3 Karakter Olmalıdır.");
            RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Kategori Adı En Fazla 30 Karakter Olmalıdır.");
            RuleFor(x => x.CategoryName).Equal("a").WithMessage("lütfen a harfi ekleyin");
        }
    }
}
