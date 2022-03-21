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
	public class DistrictManager : IDistrictService
	{
		IDistrictDal _districtDal;

		public DistrictManager(IDistrictDal districtDal)
		{
			_districtDal = districtDal;
		}

		// GetAll - İlçe Listeleme
		public IDataResult<List<District>> GetAll()
		{
			return new SuccessDataResult<List<District>>(_districtDal.GetAll(),Messages.Listed);
		}

		// GetById Id'ye göre ilçe getirme
		public IDataResult<District> GetById(int districtId)
		{
			var district = _districtDal.GetById(d => d.Id == districtId);
			return new SuccessDataResult<District>(district);
		}

		// GetDistrictByCity - Şehire göre ilçe getirme
		public IDataResult<List<District>> GetDistrictByCity(int cityId)
		{
			var district = _districtDal.GetAll(d=>d.CityId==cityId);
			return new SuccessDataResult<List<District>>(district);
		}
	}
}
