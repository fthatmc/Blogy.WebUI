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
	public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
	{
        BlogyContext context = new BlogyContext();
        public EfNotificationDal(BlogyContext context) : base(context)
		{
		}

        public List<Notification> Last3Notification()
        {
            var value = context.Notifications.OrderByDescending(x => x.NotificationId).Take(3).ToList();
           return value;
        }
    }
}
