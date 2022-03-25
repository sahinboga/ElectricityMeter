using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class MeterDetailManager : IMeterDetailService
	{
		IMeterDetailDal _meterDetailDal;

		public MeterDetailManager(IMeterDetailDal meterDetailDal)
		{
			_meterDetailDal = meterDetailDal;
		}

		public IResult Add(MeterDetail meter)
		{
			_meterDetailDal.Add(meter);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(MeterDetail meter)
		{
			_meterDetailDal.Delete(meter);
			return new SuccessResult(Messages.Deleted);
		}

		public IDataResult<List<MeterDetail>> GetAll()
		{
			return new SuccessDataResult<List<MeterDetail>>(_meterDetailDal.GetAll(), Messages.Listed);
		}

		public IDataResult<MeterDetail> GetById(int meterDetailId)
		{
			var meter = _meterDetailDal.GetById(m => m.Id == meterDetailId);
			return new SuccessDataResult<MeterDetail>(meter);
		}

		public IResult Update(MeterDetail meter)
		{
			_meterDetailDal.Update(meter);
			return new SuccessResult(Messages.Updated);
		}
	}
}
