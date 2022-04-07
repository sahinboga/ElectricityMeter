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

		[DisplayName("E-mail Adresi")]
		public string Email { get; set; }

		[DisplayName("Durum")]
		public string Status { get; set; }
	}
}
