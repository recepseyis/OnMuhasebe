using FluentValidation;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Valitadions
{
    public class KasaValidator : AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("Kasa Adı Boş Geçilemez");
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("Kasa Kodu Boş Geçilemez");
        }
    }
}