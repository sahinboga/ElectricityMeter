using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
	public interface ICompanyDal:IEntityRepository<Company>
	{
		List<CompanyDetailDto> GetAllWithDetails(FirmaTipiEnum firmaTipi);
	}
}
