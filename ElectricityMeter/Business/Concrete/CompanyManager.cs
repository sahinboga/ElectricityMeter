using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
	public class CompanyManager : ICompanyService
	{
		ICompanyDal _companyDal;

		public CompanyManager(ICompanyDal companyDal)
		{
			_companyDal = companyDal;
		}
		[ValidationAspect(typeof(CompanyValidator))]
		public IResult Add(Company company)
		{
			_companyDal.Add(company);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(Company company)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Company>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<Company> GetById(int companyId)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Company company)
		{
			throw new NotImplementedException();
		}
	}
}
