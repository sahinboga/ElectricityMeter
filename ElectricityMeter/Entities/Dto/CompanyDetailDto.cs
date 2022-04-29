using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
	public class CompanyDetailDto
	{
		[DisplayName("#")]
		public int Id { get; set; }

		[DisplayName("Firma Adı")]
		public string CompanyName { get; set; }

		[DisplayName("İl-İlçe")]
		public string Location { get; set; }

		[DisplayName("Adres")]
		public string Address { get; set; }

		[DisplayName("Telefon No")]
		public string Phone { get; set; }

		[DisplayName("Sayaç No")]
		public string MeterNo { get; set; }

		[DisplayName("Abone No")]
		public string SubscriberNo { get; set; }

		[DisplayName("Sayaç Çarpanı")]
		public int MeterMultipy { get; set; }

		[DisplayName("Trafo Gücü")]
		public int TransformerPower { get; set; }

		[DisplayName("Durum")]
		public string Status { get; set; }
	}
}
