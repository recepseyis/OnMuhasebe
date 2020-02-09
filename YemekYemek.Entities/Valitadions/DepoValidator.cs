using System;
using System.Linq;
using FluentValidation;
using YemekYemek.Entities.Extensions.FluentValidations;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Valitadions
{
    public class DepoValidator : AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo Adı Boş Geçilemez");
            RuleFor(p => p.DepoKodu).IsUnique();
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo Kodu Boş Geçilemez");
        }
    }
}