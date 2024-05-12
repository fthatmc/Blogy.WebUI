using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DtoLayer.ArticleDtos
{
    public class ResultArticleDto
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string CoverImageURL { get; set; }
        public DateTime CreateDate { get; set; }
        public string WriterName { get; set; }
        public string WriterImageURL { get; set; }
    }
}
