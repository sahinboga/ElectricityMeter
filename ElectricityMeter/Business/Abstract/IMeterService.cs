using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IMeterService
	{
		IDataResult<List<Meter>> GetAll();
		IResult Add(Meter meter);
		IDataResult<Meter> GetById(int meterId);
		IResult Update(Meter meter);
		IResult Delete(Meter meter);
	}
}
