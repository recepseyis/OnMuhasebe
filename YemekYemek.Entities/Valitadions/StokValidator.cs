using FluentValidation;
using YemekYemek.Entities.Extensions.FluentValidations;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Valitadions
{
    public class StokValidator : AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu Boş Geçilemez.");
            RuleFor(p => p.StokKodu).IsUnique();
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Adı Boş Geçilemez.").Length(5, 50).WithMessage("Stok Adı Alanı En Az 5 Karakter Olabilir.");
            RuleFor(p => p.Birimi).NotEmpty().WithMessage("Birimi Seçmeniz Gerekir");
            RuleFor(p => p.AlisFiyati).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı 0'dan Küçük Olamaz.");
            RuleFor(p => p.SatisFiyati).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı 0'dan Küçük Olamaz.");
        }
    }
}