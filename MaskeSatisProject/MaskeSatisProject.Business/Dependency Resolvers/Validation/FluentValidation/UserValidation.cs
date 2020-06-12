using FluentValidation;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.Business.Dependency_Resolvers.Validation.FluentValidation
{
    public class UserValidation:AbstractValidator<Users>
    {
        public UserValidation()
        {
            RuleFor(x => x.TcNo).NotEmpty().WithMessage("Tc no boş olamaz..")
                .Length(11).WithMessage("Tc no 11 hane olmalıdır!");
            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Sifre alanı boş bırakılamaz..").Length(8,14).WithMessage("Şifreniz 8 ile 15 karakter arası olmalıdır.");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Ad alanı boş bırakılamaz..");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad alanı boş bırakılamaz..");
            RuleFor(x => x.DayOfBirth).NotEmpty().WithMessage("Doğum tarihi alanı boş bırakılamaz..");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E mail alanı boş bırakılamaz..");
        }
    }
}
