using Blogy.DataAccesLayer.Abstract;
using Blogy.DataAccesLayer.Context;
using Blogy.DataAccesLayer.Repository;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        BlogyContext context = new BlogyContext();

		public EfCommentDal(BlogyContext context) : base(context)
		{
		}

		public List<Comment> GetCommentsByArticleId(int id)
        {
            var values = context.Comments.Where(x => x.ArticleID == id).ToList();
            return values;
        }

        public List<Comment> GetListAll(int id)
        {
            var values = context.Comments.Where(x => x.AppUserID == id).ToList();
            return values;
        }

       
    }
}
