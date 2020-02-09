using FluentValidation;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Valitadions
{
    public class TanimValidator : AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Tanimi).NotEmpty().WithMessage("Tanım Boş Geçilemez");
            RuleFor(p => p.Turu).NotEmpty().WithMessage("Tanım Türü Kodu Kodu Boş Geçilemez");
        }
    }
}