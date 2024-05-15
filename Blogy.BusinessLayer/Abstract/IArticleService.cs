using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {

        List<Article> TGetArticleStatusTrue();
        void TChangeToTrueArticleStatus(int id);
        void TChangeToFalseArticleStatus(int id);
        List<Article> TGetArticleWithWriter();
        Writer TGetWriterInfoByArticleWriter(int id);
        List<Article> TGetArticlesByWriter(int id);
        Article TGetArticleWithWriterModel(int id);
        List<Article> TGetLast4Article();
        List<Article> TCurrent3Article(int id);
        List<Article> TCurrent3Article();
		List<Article> TGetArticleFilterList(string search);
        List<Article> TCurrent4Article(int id);
        List<Article> TGetListAll(int id);
       
    }
}
