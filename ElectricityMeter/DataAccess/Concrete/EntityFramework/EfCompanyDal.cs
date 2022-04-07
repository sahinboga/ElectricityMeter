using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	// combolarda kullanılan firma tipi enumeration
	public enum FirmaTipiEnum
	{
		All = 0,
		Aktif,
		Pasif
	}

	public class EfCompanyDal : EfEntityRepositoryBase<Company, ElectricityMeterContext>, ICompanyDal
	{
		

		// GetAllWithDetails - firma tipine göre kayıtları joinli döndürür
		public List<CompanyDetailDto> GetAllWithDetails(FirmaTipiEnum firmaTipi)
		{
			using (var context = new ElectricityMeterContext())
			{
				List<CompanyDetailDto> list = new List<CompanyDetailDto>();

				switch (firmaTipi)
				{
					case FirmaTipiEnum.All:
						{
							var result = from c in context.Companies
										 join d in context.Districts on c.DistrictId equals d.Id
										 join city in context.Cities on d.CityId equals city.Id
										 select new CompanyDetailDto
										 {
											 Id = c.Id,
											 Address = c.Address,
											 CompanyName = c.CompanyName,
											 Email = c.Email,
											 Location = city.CityName + "-" + d.DistrictName,
											 Phone = c.Phone,
											 Status = c.Status == true ? "Aktif" : "Pasif"
										 };

							list = result.ToList();
							break;
						}
					case FirmaTipiEnum.Aktif:
						{
							var result = from c in context.Companies
										 join d in context.Districts on c.DistrictId equals d.Id
										 join city in context.Cities on d.CityId equals city.Id
										 where c.Status == true
										 select new CompanyDetailDto
										 {
											 Id = c.Id,
											 Address = c.Address,
											 CompanyName = c.CompanyName,
											 Email = c.Email,
											 Location = city.CityName + "-" + d.DistrictName,
											 Phone = c.Phone,
											 Status = c.Status == true ? "Aktif" : "Pasif"
										 };

							list = result.ToList();
							break;
						}
					case FirmaTipiEnum.Pasif:
						{
							var result = from c in context.Companies
										 join d in context.Districts on c.DistrictId equals d.Id
										 join city in context.Cities on d.CityId equals city.Id
										 where c.Status == false
										 select new CompanyDetailDto
										 {
											 Id = c.Id,
											 Address = c.Address,
											 CompanyName = c.CompanyName,
											 Email = c.Email,
											 Location = city.CityName + "-" + d.DistrictName,
											 Phone = c.Phone,
											 Status = c.Status == true ? "Aktif" : "Pasif"
										 };

							list = result.ToList();
							break;
						}
					default:
						break;
				}

				return list;
			}
		}
	}
}
