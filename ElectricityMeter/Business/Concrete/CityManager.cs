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
	public class CityManager : ICityService
	{
		ICityDal _cityDal;

		public CityManager(ICityDal cityDal)
		{
			_cityDal = cityDal;
		}

		public IDataResult<List<City>> GetAll()
		{
			return new SuccessDataResult<List<City>>(_cityDal.GetAll(), Messages.Listed);
		}

		// GetById - Id'ye göre veri getirir
		public IDataResult<City> GetById(int cityId)
		{
			var city =_cityDal.GetById(c=>c.Id==cityId);
			return new SuccessDataResult<City>(city);
		}

	}
}
