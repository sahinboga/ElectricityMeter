using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
	public class CompanyValidator:AbstractValidator<Company>
	{
		public CompanyValidator()
		{
			RuleFor(c => c.CompanyName).NotEmpty();
			RuleFor(c => c.CompanyName).MinimumLength(5);
			RuleFor(c => c.Address).NotEmpty();
			RuleFor(c => c.Phone).MaximumLength(14);
		}
	}
}
