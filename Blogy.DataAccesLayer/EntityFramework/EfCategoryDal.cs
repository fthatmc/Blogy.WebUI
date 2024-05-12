using Blogy.DataAccesLayer.Abstract;
using Blogy.DataAccesLayer.Context;
using Blogy.DataAccesLayer.Repository;
using Blogy.Dto.Layer.CategoryDto;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        BlogyContext _context = new BlogyContext();

        public EfCategoryDal(BlogyContext context) : base(context)
		{
		}

		public List<CategoryCountDto> GetCategoriesAndCount()
        {
            var values = _context.Articles.GroupBy(x => x.CategoryId).Select(y => new CategoryCountDto()
            {
                CategoryID = y.Key,
                Name = _context.Categorys.Where(x => x.CategoryId == y.Key).Select(z => z.CategoryName).FirstOrDefault(),
                Count = y.Count(),
            }).ToList();
            return values;
        }

        public int GetCategoryCount()
        {
            return _context.Categorys.Count();
        }
    }
}
