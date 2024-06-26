﻿using Blogy.Dto.Layer.CategoryDto;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {
        int TGetCategoryCount();
        List<CategoryCountDto> TGetCategoriesAndCount();
    }
}
