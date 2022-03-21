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
	public class MeterManager : IMeterService
	{
		IMeterDal _meterDal;

		public MeterManager(IMeterDal meterDal)
		{
			_meterDal = meterDal;
		}

		public IResult Add(Meter meter)
		{
			_meterDal.Add(meter);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(Meter meter)
		{
			_meterDal.Delete(meter);
			return new SuccessResult(Messages.Deleted);
		}

		public IDataResult<List<Meter>> GetAll()
		{
			return new SuccessDataResult<List<Meter>>(_meterDal.GetAll(), Messages.Listed);
		}

		public IDataResult<Meter> GetById(int meterId)
		{
			var meter=_meterDal.GetById(m=>m.Id==meterId);
			return new SuccessDataResult<Meter>(meter);
		}

		public IResult Update(Meter meter)
		{
			_meterDal.Update(meter);
			return new SuccessResult(Messages.Updated);
		}
	}
}
