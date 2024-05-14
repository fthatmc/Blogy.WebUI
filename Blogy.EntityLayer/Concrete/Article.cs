using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.EntityLayer.Concrete
{
	public class Article
	{
        public int ArticleId { get; set; }
		public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public string? CoverImageUrl { get; set; }
		//? zorunlu değil null dönebilir
		public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int WriterId { get; set; }
        public Writer Writer { get; set; }
        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<Comment> Comments { get; set; }

        public bool Status { get; set; }


    }
}
