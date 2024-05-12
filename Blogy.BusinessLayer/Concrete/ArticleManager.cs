using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccesLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public Article TGetArticleWithWriterModel(int id)
        {
            return _articleDal.GetArticleWithWriterModel(id);
        }

        public void TDelete(int id)
        {
            if (id != 0)
            {
                _articleDal.Delete(id);
            }
            else
            {
                //hata mesajı
            }
        }

        public List<Article> TGetArticlesByWriter(int id)
        {
            return _articleDal.GetArticlesByWriter(id);
        }

        public List<Article> TGetArticleWithWriter()
        {
            return _articleDal.GetArticleWithWriter();
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
        }

        public List<Article> TGetListAll()
        {
          return _articleDal.GetListAll();
        }

        public Writer TGetWriterInfoByArticleWriter(int id)
        {
            return _articleDal.GetWriterInfoByArticleWriter(id);
        }

        public void TInsert(Article entity)
        {
                _articleDal.Insert(entity);

        }

        public void TUpdate(Article entity)
        {  
                _articleDal.Update(entity);
        }

        public List<Article> TCurrent3Article(int id)
        {
          return  _articleDal.Current3Article(id);
        }

        public List<Article> TGetLast4Article()
        {
            return _articleDal.GetLast4Article();
        }

        public List<Article> TCurrent3Article()
        {
            return _articleDal.Current3Article();
        }

		public List<Article> TGetArticleFilterList(string search)
		{
            return _articleDal.GetArticleFilterList(search);
		}

        public List<Article> TCurrent4Article(int id)
        {
            return _articleDal.Current4Article(id);
        }

        public List<Article> TGetListAll(int id)
        {
           return _articleDal.GetListAll(id);
        }

        
    }
}
