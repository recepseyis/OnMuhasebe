using FluentValidation;
using YemekYemek.Entities.Extensions.FluentValidations;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Valitadions
{
    public class FisValidator : AbstractValidator<Fis>
    {
        public FisValidator()
        {
            RuleFor(p => p.FisKodu).IsUnique();
        }
    }
}