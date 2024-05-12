using Blogy.DataAccesLayer.Abstract;
using Blogy.DataAccesLayer.Context;
using Blogy.DataAccesLayer.Repository;
using Blogy.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        BlogyContext context = new BlogyContext();

		public EfArticleDal(BlogyContext context) : base(context)
		{
		}

		public List<Article> Current3Article(int id)
        {
            
            var values = context.Articles.Where(x => x.WriterId == 2).OrderByDescending(x=>x.CreateDate).Take(3).ToList();
            return values;
        }

        public List<Article> Current3Article()
        {
            var values = context.Articles.OrderByDescending(x => x.CreateDate).Take(3).ToList();
            return values;
        }

        public List<Article> Current4Article(int id)
        {
            var values = context.Articles.Where(x => x.AppUserId == id).OrderByDescending(x => x.CreateDate).Take(4).ToList();
            return values;
        }

        public List<Article> GetArticleFilterList(string search)
		{
			var values = context.Articles.Where(x => x.Title.Contains(search)).Include(x => x.Writer).ToList();
			return values;
		}

       

        public List<Article> GetArticlesByWriter(int id)
        {
            var values = context.Articles.Where(x=>x.AppUserId == id).ToList();
            return values;
        }

        public List<Article> GetArticleWithWriter()
        {
            var values = context.Articles.Include(x => x.Writer).ToList();
            return values;
        }

        public Article GetArticleWithWriterModel(int id)
        {
            var values = context.Articles.Where(x => x.ArticleId == id).Include(x => x.Writer).FirstOrDefault();
            return values;
        }

        public List<Article> GetLast4Article()
        {
            var values = context.Articles.OrderByDescending(x => x.CreateDate).Take(4).ToList();
            return values;
        }

        public List<Article> GetListAll(int id)
        {
            var values = context.Articles.Where(x => x.AppUserId == id).ToList();
            return values;
        }

        public Writer GetWriterInfoByArticleWriter(int id)
        {
            var values = context.Articles.Where(x=>x.ArticleId == id).Select(y=>y.Writer).FirstOrDefault();
            return values;
        }

        
    }
}
