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
	public class EfWriterDal : GenericRepository<Writer>, IWriterDal
	{
        BlogyContext context = new BlogyContext();
        public EfWriterDal(BlogyContext context) : base(context)
		{
		}

        public void ChangeToFalseWriterStatus(int id)
        {
            var values = context.Writers.Find(id);
            values.Status = false;
            context.SaveChanges();
        }

        public void ChangeToTrueWriterStatus(int id)
        {
            var values = context.Writers.Find(id);
            values.Status = true;
            context.SaveChanges();
        }
    }
}
