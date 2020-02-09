using FluentValidation;
using YemekYemek.Entities.Extensions.FluentValidations;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Valitadions
{
    public class CariValidator : AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu Boş Geçilemez.");
            RuleFor(p => p.CariKodu).IsUnique();
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı Boş Geçilemez.");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı Boş Geçilemez.");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon Boş Geçilemez.");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Email Adresi Geçersiz.");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("İskonto Oranı 0'dan Küçük Olamaz.");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk Limiti 0'dan Küçük Olamaz.");
        }
    }
}