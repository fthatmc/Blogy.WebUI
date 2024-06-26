﻿using Blogy.DataAccesLayer.Abstract;
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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        BlogyContext context = new BlogyContext();

		public EfCommentDal(BlogyContext context) : base(context)
		{
		}

        public void ChangeToStatusFalse(int id)
        {
            var values = context.Comments.Find(id);
            values.Status = false;
            context.SaveChanges();
        }

        public void ChangeToStatusTrue(int id)
        {
            var values = context.Comments.Find(id);
            values.Status = true;
            context.SaveChanges();
        }

        public List<Comment> GetCommentsByArticleId(int id)
        {
            var values = context.Comments.Where(x => x.ArticleID == id).ToList();
            return values;
        }

        public List<Comment> GetCommentsWithArticleAndUser()
        {
            var values = context.Comments.Include(x => x.Article).Include(x => x.AppUser).ToList();
            return values;
        }

        public List<Comment> GetListAll(int id)
        {
            var values = context.Comments.Where(x => x.AppUserID == id).ToList();
            return values;
        }

       
    }
}
