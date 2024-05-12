using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.Dto.Layer.ArticleDtos
{
    public class ForBlogArticleDto
    {
        public int ArticleId { get; set; }
        public string CoverImage { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
