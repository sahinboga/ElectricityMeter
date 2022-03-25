﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IMeterDetailService
	{
		IDataResult<List<MeterDetail>> GetAll();
		IResult Add(MeterDetail meter);
		IDataResult<MeterDetail> GetById(int meterDetailId);
		IResult Update(MeterDetail meter);
		IResult Delete(MeterDetail meter);
	}
}