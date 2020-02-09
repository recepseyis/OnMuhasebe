using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekYemek.Entities.Extensions.FluentValidations;
using YemekYemek.Entities.Tables;

namespace YemekYemek.Entities.Valitadions
{
    public class KullaniciValidator : AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
        }
    }
}
