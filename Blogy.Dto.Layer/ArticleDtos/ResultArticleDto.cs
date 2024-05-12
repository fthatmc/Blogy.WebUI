
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.Dto.Layer.ArticleDtos
{
    public class ResultArticleDto
    {
        public int ArticleId { get; set; }
        public string CoverImage { get; set; }
        public string Title { get; set; }
        public string WriterImage { get; set; }
        public string WriterName { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
