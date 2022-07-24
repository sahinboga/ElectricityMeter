using Core.Entity;
using System.ComponentModel;

namespace Entities.Dto
{
	public class MeterDto:IEntity
	{
		[DisplayName("#")]
		public int Id { get; set; }

		[DisplayName("Firma Adı")]
		public string CompanyName { get; set; }

		[DisplayName("Günlük Oran (5.8.0)")]
		public double IDailyRate { get; set; }

		[DisplayName("Toplam Oran (5.8.0)")]
		public double ITotalRate { get; set; }

		[DisplayName("Günlük Oran (8.8.0)")]
		public double CDailyRate { get; set; }

		[DisplayName("Toplam Oran (8.8.0)")]
		public double CTotalRate { get; set; }

		[DisplayName("Günlük Tüketim (1.8.0)")]
		public double ADailyConsumption { get; set; }

		[DisplayName("Günlük Tüketim (5.8.0)")]
		public double IDailyConsumption { get; set; }

		[DisplayName("Günlük Tüketim (8.8.0)")]
		public double CDailyConsumption { get; set; }
	}
}
