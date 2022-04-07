using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;

namespace Business.Abstract
{
	public interface ICompanyService
	{
		IDataResult<List<Company>> GetAll();
		IDataResult<List<CompanyDetailDto>> GetAllWithDetails(FirmaTipiEnum firmaTipi);
		IResult Add(Company company);
		IDataResult<Company> GetById(int companyId);
		IResult Update(Company company);
		IResult Delete(Company company);
	}
}
