using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class MeterDetail:IEntity
	{
		public int Id { get; set; }
		public int MeterId { get; set; }
		public float Active { get; set; }
		public float Inductive { get; set; }
		public float Capacitive { get; set; }
		public DateTime ReadDate { get; set; }
	}
}
