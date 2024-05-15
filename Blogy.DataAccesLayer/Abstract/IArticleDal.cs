using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.Abstract
{
	public interface IArticleDal : IGenericDal<Article>
	{
		List<Article> GetArticleStatusTrue();
        void ChangeToTrueArticleStatus(int id);
        void ChangeToFalseArticleStatus(int id);
        List<Article> GetArticleWithWriter();
		Writer GetWriterInfoByArticleWriter(int id);
        List<Article> GetArticlesByWriter(int id);
		Article GetArticleWithWriterModel(int id);
		List<Article> Current3Article(int id);
		List<Article> Current4Article(int id);
        List<Article> Current3Article();
        List<Article> GetLast4Article();
		List<Article> GetArticleFilterList(string search);
		List<Article> GetListAll(int id);

    }
}
