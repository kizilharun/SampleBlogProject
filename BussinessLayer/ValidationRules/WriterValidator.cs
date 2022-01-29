using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer> 
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("this field cannot be left blank !!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("this field cannot be left blank !!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("this field cannot be left blank !!");
            RuleFor(x => x.WriterPassword).MaximumLength(2).WithMessage("cannot be less than two character !!");
            
        }
    }
}
