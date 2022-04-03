using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
	public class MeterDto:IEntity
	{
		[DisplayName("#")]
		public int Id { get; set; }

		[DisplayName("Firma Adı")]
		public string CompanyName { get; set; }

		[DisplayName("Sayaç No")]
		public string MeterNo { get; set; }

		[DisplayName("Abone No")]
		public string SubscriberNo { get; set; }

		[DisplayName("Sayaç Çarpanı")]
		public int Multipy { get; set; }

		[DisplayName("Sayaç Gücü")]
		public int MeterPower { get; set; }
	}
}
