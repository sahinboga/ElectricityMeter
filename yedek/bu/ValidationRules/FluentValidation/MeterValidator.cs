using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
	public class MeterValidator: AbstractValidator<Meter>
	{
		public MeterValidator()
		{
			RuleFor(m => m.MeterNo).NotEmpty();
			RuleFor(m => m.SubscriberNo).NotEmpty();
			RuleFor(m => m.Multipy).NotEmpty();
			RuleFor(m => m.MeterPower).NotEmpty();
			RuleFor(m => m.Active).NotEmpty();
			RuleFor(m => m.Inductive).NotEmpty();
			RuleFor(m => m.Capacitive).NotEmpty();
			RuleFor(m => m.ReadDate).NotEmpty();
		}
	}
}
