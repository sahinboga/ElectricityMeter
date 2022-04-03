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
	public class EfMeterDal : EfEntityRepositoryBase<Meter, ElectricityMeterContext>, IMeterDal
	{
		public List<MeterDto> GetAllWithDetails()
		{
			using (var context = new ElectricityMeterContext())
			{
				var result = from m in context.Meters
							 join c in context.Companies on m.CompanyId equals c.Id
							 select new MeterDto
							 {
								 Id=m.Id,
								 CompanyName=c.CompanyName,
								 MeterNo=m.MeterNo,
								 MeterPower=m.MeterPower,
								 Multipy=m.Multipy,
								 SubscriberNo=m.SubscriberNo
							 };
				return result.ToList();
			}
		}
	}
}
