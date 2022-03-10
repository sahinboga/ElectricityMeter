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
	public class DistrictManager : IDistrictService
	{
		IDistrictDal _districtDal;

		public DistrictManager(IDistrictDal districtDal)
		{
			_districtDal = districtDal;
		}

		public IDataResult<List<District>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<District> GetById(int districtId)
		{
			throw new NotImplementedException();
		}
	}
}
