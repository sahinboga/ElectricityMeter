using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICompanyService
	{
		IDataResult<List<Company>> GetAll();
		IDataResult<List<CompanyDetailDto>> GetAllWithDetails();
		IResult Add(Company company);
		IDataResult<Company> GetById(int companyId);
		IResult Update(Company company);
		IResult Delete(Company company);
		List<string> GetByCompanyName();
	}
}
