﻿using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.Abstract
{
	public interface IWriterDal : IGenericDal<Writer>
	{
        void ChangeToTrueWriterStatus(int id);
        void ChangeToFalseWriterStatus(int id);
    }
}
