﻿using BenMabelProject.Entity.DtoS;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Services.FluentValidations
{
    public class ArticleUpdateValidator : AbstractValidator<ArticleUpdateDto>
    {
        public ArticleUpdateValidator()
        {
            RuleFor(b => b.Title).NotEmpty().NotNull().MinimumLength(5).WithName("Başlık");
            RuleFor(b => b.SmlContent).NotEmpty().NotNull().MaximumLength(140).WithName("Kısa Metin");
            RuleFor(b => b.SmlContent).NotEmpty().NotNull().WithName("Metin");
        }
    }
}
