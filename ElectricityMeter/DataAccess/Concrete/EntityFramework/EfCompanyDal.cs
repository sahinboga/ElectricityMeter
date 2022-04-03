using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCompanyDal : EfEntityRepositoryBase<Company, ElectricityMeterContext>, ICompanyDal
	{
		public List<CompanyDetailDto> GetAllWithDetails()
		{
			using(var context = new ElectricityMeterContext())
			{
				var result = from c in context.Companies
							 join d in context.Districts on c.DistrictId equals d.Id
							 join city in context.Cities on d.CityId equals city.Id
							 select new CompanyDetailDto {
								 Id = c.Id,
								 Address = c.Address,
								 CompanyName = c.CompanyName,
								 Email = c.Email,
								 Location = city.CityName + "-" + d.DistrictName,
								 Phone = c.Phone,
							 };
				return result.ToList();
			}
		}
	}
}
