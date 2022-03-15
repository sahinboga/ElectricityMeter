using Business.Abstract;
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
			throw new NotImplementedException();
		}

		public IResult Delete(Meter meter)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Meter>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<Meter> GetById(int meterId)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Meter meter)
		{
			throw new NotImplementedException();
		}
	}
}
