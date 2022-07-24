using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
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
										 join d in context.Districts on c.DistrictId equals d.Id into dInto
										 from dLeft in dInto.DefaultIfEmpty()
										 join city in context.Cities on dLeft.CityId equals city.Id into cityInto
										 from cityLeft in cityInto.DefaultIfEmpty()
										 join m in context.Meters on c.Id equals m.CompanyId into mInto
										 from mLeft in mInto.DefaultIfEmpty()
										 select new CompanyDetailDto
										 {
											 Id = c.Id,
											 Address = c.Address,
											 CompanyName = c.CompanyName,
											 Location = cityLeft.CityName + "-" + dLeft.DistrictName,
											 Phone = c.Phone,
											 MeterNo = mLeft.MeterNo == null ? "" : mLeft.MeterNo,
											 SubscriberNo = mLeft.SubscriberNo == null ? "" : mLeft.SubscriberNo,
											 MeterMultipy = mLeft.Multipy == null ? 0 : mLeft.Multipy,
											 TransformerPower = mLeft.MeterPower == null ? 0 : mLeft.MeterPower,
											 Status = c.Status == true ? "Aktif" : "Pasif"
										 };

							list = result.ToList();
							break;
						}
					case FirmaTipiEnum.Aktif:
						{
							var result = from c in context.Companies
										 join d in context.Districts on c.DistrictId equals d.Id into dInto
										 from dLeft in dInto.DefaultIfEmpty()
										 join city in context.Cities on dLeft.CityId equals city.Id into cityInto
										 from cityLeft in cityInto.DefaultIfEmpty()
										 join m in context.Meters on c.Id equals m.CompanyId into mInto
										 from mLeft in mInto.DefaultIfEmpty()
										 select new CompanyDetailDto
										 {
											 Id = c.Id,
											 Address = c.Address,
											 CompanyName = c.CompanyName,
											 Location = cityLeft.CityName + "-" + dLeft.DistrictName,
											 Phone = c.Phone,
											 MeterNo = mLeft.MeterNo == null ? "" : mLeft.MeterNo,
											 SubscriberNo = mLeft.SubscriberNo == null ? "" : mLeft.SubscriberNo,
											 MeterMultipy = mLeft.Multipy == null ? 0 : mLeft.Multipy,
											 TransformerPower = mLeft.MeterPower == null ? 0 : mLeft.MeterPower,
											 Status = c.Status == true ? "Aktif" : "Pasif"
										 };

							list = result.Where(x => x.Status == "Aktif").ToList();
							break;
						}
					case FirmaTipiEnum.Pasif:
						{
							var result = from c in context.Companies
										 join d in context.Districts on c.DistrictId equals d.Id into dInto
										 from dLeft in dInto.DefaultIfEmpty()
										 join city in context.Cities on dLeft.CityId equals city.Id into cityInto
										 from cityLeft in cityInto.DefaultIfEmpty()
										 join m in context.Meters on c.Id equals m.CompanyId into mInto
										 from mLeft in mInto.DefaultIfEmpty()
										 select new CompanyDetailDto
										 {
											 Id = c.Id,
											 Address = c.Address,
											 CompanyName = c.CompanyName,
											 Location = cityLeft.CityName + "-" + dLeft.DistrictName,
											 Phone = c.Phone,
											 MeterNo = mLeft.MeterNo == null ? "" : mLeft.MeterNo,
											 SubscriberNo = mLeft.SubscriberNo == null ? "" : mLeft.SubscriberNo,
											 MeterMultipy = mLeft.Multipy == null ? 0 : mLeft.Multipy,
											 TransformerPower = mLeft.MeterPower == null ? 0 : mLeft.MeterPower,
											 Status = c.Status == true ? "Aktif" : "Pasif"
										 };

							list = result.Where(x => x.Status == "Pasif").ToList();
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
