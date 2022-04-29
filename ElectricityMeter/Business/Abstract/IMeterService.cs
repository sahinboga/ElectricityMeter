using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;

namespace Business.Abstract
{
	public interface IMeterService
	{
		IDataResult<List<Meter>> GetAll();
		IDataResult<List<MeterDto>> GetAllWithDetails();
		IResult Add(Meter meter);
		IDataResult<Meter> GetById(int meterId);
		IResult Update(Meter meter);
		IResult Delete(Meter meter);
	}
}
