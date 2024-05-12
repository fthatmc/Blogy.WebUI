using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.Dto.Layer.CommentDto
{
	public class CommentDto
	{
		
		public string Content { get; set; }
		public DateTime CommentDate { get; set; }
		public int ArticleId { get; set; }
		public string Name { get; set; }
		public bool Status { get; set; }
	}
}
