using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Meter:IEntity
	{
		public int Id { get; set; }
		public int CompanyId { get; set; }
		public string MeterNo { get; set; }
		public string SubscriberNo { get; set; }
		public int Multipy { get; set; }
		public int MeterPower { get; set; }
	}
}
