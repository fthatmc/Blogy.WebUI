﻿using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccesLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TChangeToStatusFalse(int id)
        {
            _commentDal.ChangeToStatusFalse(id);
        }

        public void TChangeToStatusTrue(int id)
        {
            _commentDal.ChangeToStatusTrue(id);
        }

        public void TDelete(int id)
        {
            _commentDal.Delete(id);
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> TGetCommentsByArticleId(int id)
        {
            return _commentDal.GetCommentsByArticleId(id);
        }

        public List<Comment> TGetCommentsWithArticleAndUser()
        {
           return _commentDal.GetCommentsWithArticleAndUser();
        }

        public List<Comment> TGetListAll()
        {
            return _commentDal.GetListAll();
        }

        public List<Comment> TGetListAll(int id)
        {
            return _commentDal.GetListAll(id);
        }

        public void TInsert(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        

        public void TUpdate(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}
