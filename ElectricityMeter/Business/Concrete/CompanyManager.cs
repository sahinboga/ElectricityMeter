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

		// Add - Firma ekleme
		[ValidationAspect(typeof(CompanyValidator))]
		public IResult Add(Company company)
		{
			_companyDal.Add(company);
			return new SuccessResult(Messages.Added);
		}

		// Delete - Firma Silme
		public IResult Delete(Company company)
		{
			_companyDal.Delete(company);
			return new SuccessResult(Messages.Deleted);
		}

		// GetAll - Firma Listeleme
		public IDataResult<List<Company>> GetAll()
		{
			return new SuccessDataResult<List<Company>>(_companyDal.GetAll(), Messages.Listed);
		}

		// GetById - Id'ye göre firma getirme
		public IDataResult<Company> GetById(int companyId)
		{
			var company = _companyDal.GetById(c => c.Id == companyId);
			return new SuccessDataResult<Company>(company);
		}

		// Update Firma güncelleme
		public IResult Update(Company company)
		{
			_companyDal.Update(company);
			return new SuccessResult(Messages.Updated);
		}
	}
}
