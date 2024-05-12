﻿using Blogy.DataAccesLayer.Abstract;
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
	public class EfSendMessageDal : GenericRepository<SendMessage>, ISendMessageDal
	{
		public EfSendMessageDal(BlogyContext context) : base(context)
		{
		}
	}
}
