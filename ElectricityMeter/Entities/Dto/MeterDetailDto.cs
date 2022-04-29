using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
	public class MeterDetailDto:IEntity
	{
		[DisplayName("#")]
		public int Id { get; set; }

		[DisplayName("Tarih")]
		public DateTime ReadDate { get; set; }

		[DisplayName("Aktif")]
		public double Active { get; set; }

		[DisplayName("Endüktif")]
		public double Inductive { get; set; }

		[DisplayName("Durum")]
		public string IStatu { get; set; }

		[DisplayName("Sınır Aktif")]
		public double ILimitActive { get; set; }

		[DisplayName("Günlük Oran")]
		public double IDailyRate { get; set; }

		[DisplayName("Toplam Oran")]
		public double ITotalRate { get; set; }

		//[DisplayName("Gün")]
		//public string IDay { get; set; }

		[DisplayName("Kapasitif")]
		public double Capacitive { get; set; }

		[DisplayName("Durum")]
		public string CStatu { get; set; }

		[DisplayName("Sınır Aktif")]
		public double CLimitActive { get; set; }

		[DisplayName("Günlük Oran")]
		public double CDailyRate { get; set; }

		[DisplayName("Toplam Oran")]
		public double CTotalRate { get; set; }

		//[DisplayName("Gün")]
		//public string CDay { get; set; }

		[DisplayName("Günlük Tüketim (1.8.0)")]
		public double ADailyConsumption { get; set; }

		[DisplayName("Günlük Tüketim (5.8.0)")]
		public double IDailyConsumption { get; set; }

		[DisplayName("Günlük Tüketim (8.8.0)")]
		public double CDailyConsumption { get; set; }

		

	}
}
