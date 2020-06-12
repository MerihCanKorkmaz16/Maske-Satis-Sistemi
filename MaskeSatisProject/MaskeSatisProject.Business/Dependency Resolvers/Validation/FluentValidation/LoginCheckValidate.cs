using FluentValidation;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.Business.Dependency_Resolvers.Validation.FluentValidation
{
    public class LoginCheckValidate: AbstractValidator<Users>
    {
        public LoginCheckValidate()
        {
            RuleFor(x => x.TcNo).NotEmpty().WithMessage("Tc no boş olamaz..")
                .Length(11).WithMessage("Tc no 11 hane olmalıdır!");
            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Sifre alanı boş bırakılamaz..");
            
        }
    }
}
