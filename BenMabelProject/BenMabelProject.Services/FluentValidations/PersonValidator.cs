using BenMabelProject.Entity.DtoS.User;
using BenMabelProject.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Services.FluentValidations
{
    public class PersonValidator : AbstractValidator<CustomerAddDto>
    {
        public PersonValidator()
        {
            RuleFor(b => b.FirstName).NotEmpty().NotNull().MinimumLength(2).WithName("İsim");
            RuleFor(b => b.LastName).NotEmpty().NotNull().MinimumLength(2).WithName("Soyisim");
            RuleFor(b => b.Password).NotEmpty().NotNull().MinimumLength(6).WithName("Şifre");
            RuleFor(b => b.Email).NotEmpty().NotNull().MinimumLength(6).WithName("Email");
            RuleFor(b => b.PhoneNumber).NotEmpty().NotNull().MinimumLength(6).WithName("Telefon Numarası");
            RuleFor(b => b.Ctiy).NotEmpty().NotNull().WithName("Şehir");
            RuleFor(b => b.District).NotEmpty().NotNull().WithName("İlçe");
            RuleFor(b => b.Neighbourhood).NotEmpty().NotNull().WithName("Mahalle");
            RuleFor(b => b.Street).NotEmpty().NotNull().WithName("Sokak - Cadde");
            RuleFor(b => b.Detail).NotEmpty().NotNull().WithName("Açık Adres");

        }
    }
}
