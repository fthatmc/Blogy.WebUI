using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.Dto.Layer.CategoryDto
{
    public class CategoryCountDto
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
