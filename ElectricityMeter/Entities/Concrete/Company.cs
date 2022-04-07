using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public  class Company:IEntity
	{
		public int Id { get; set; }

		[DisplayName("Firma Adı")]
		public string CompanyName { get; set; }
		public int DistrictId { get; set; }

		[DisplayName("Adres")]
		public string Address { get; set; }

		[DisplayName("Telefon No")]
		public string Phone { get; set; }

		[DisplayName("E-mail Adresi")]
		public string Email { get; set; }
		public bool Status { get; set; }
	}
}
