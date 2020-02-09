using FluentValidation;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Valitadions
{
    public class OdemeTuruValidator : AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("Ödeme Türü Adı Boş Geçilemez");
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("Ödeme Türü Kodu Kodu Boş Geçilemez");
        }
    }
}