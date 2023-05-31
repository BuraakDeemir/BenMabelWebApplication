using BenMabelProject.Entity.DtoS.User;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Services.FluentValidations
{
    public class UserAddDtoValidator: AbstractValidator<UserAddDto>
    {
        public UserAddDtoValidator()
        {
            RuleFor(b=>b.FirstName).NotNull().NotEmpty().WithName("İsim");
            RuleFor(b=>b.LastName).NotNull().NotEmpty().WithName("Soyisim");
            RuleFor(b=>b.Password).NotNull().NotEmpty().WithName("Şifre");
            RuleFor(b=>b.Email).NotNull().NotEmpty().WithName("Email");
            RuleFor(b=>b.PhoneNumber).NotNull().NotEmpty().WithName("Telefon Numarası");
        }
    }
}
