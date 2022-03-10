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
	public class CityManager : ICityService
	{
		ICityDal _cityDal;

		public CityManager(ICityDal cityDal)
		{
			_cityDal = cityDal;
		}

		public IDataResult<List<City>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<City> GetById(int cityId)
		{
			throw new NotImplementedException();
		}
	}
}
