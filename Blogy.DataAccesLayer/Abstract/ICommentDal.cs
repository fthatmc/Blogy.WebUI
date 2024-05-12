using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.Abstract
{
	public interface ICommentDal : IGenericDal<Comment>
	{
		List<Comment> GetCommentsByArticleId(int id);
        List<Comment> GetListAll(int id);
    }
}
