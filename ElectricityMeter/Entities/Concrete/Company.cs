using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public  class Company:IEntity
	{
		public int Id { get; set; }
		public string CompanyName { get; set; }
		public int CityId { get; set; }
		public int DistrictId { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
	}
}
