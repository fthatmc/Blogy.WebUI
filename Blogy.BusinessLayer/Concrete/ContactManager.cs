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
	public class ContactManager : IContactService
	{
		private readonly IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void TDelete(int id)
		{
			_contactDal.Delete(id);
		}

		public Contact TGetById(int id)
		{
			return _contactDal.GetById(id);
		}

		public List<Contact> TGetListAll()
		{
			return _contactDal.GetListAll();
		}

		public void TInsert(Contact entity)
		{
			_contactDal.Insert(entity);
		}

		public void TUpdate(Contact entity)
		{
			_contactDal.Update(entity);
		}
	}
}
