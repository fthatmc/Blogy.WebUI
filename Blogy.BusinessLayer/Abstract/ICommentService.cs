using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> TGetCommentsByArticleId(int id);
        List<Comment> TGetListAll(int id);
        List<Comment> TGetCommentsWithArticleAndUser();
        void TChangeToStatusTrue(int id);
        void TChangeToStatusFalse(int id);
    }
}
