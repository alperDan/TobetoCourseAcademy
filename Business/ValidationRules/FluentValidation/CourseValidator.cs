using System;
using Entities.Concretes;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class CourseValidator:AbstractValidator<Course>
	{
		public CourseValidator()
		{
            RuleFor(p => p.CourseName).NotEmpty();

            RuleFor(p=>p.CourseName).MinimumLength(2);

            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);

            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p=>p.CategoryId==1);
            RuleFor(p => p.CourseName).Must(StartWithA);



        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

