using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using YemekYemek.Entities.InterFaces;
using System.Linq.Dynamic;

namespace YemekYemek.Entities.Extensions.FluentValidations
{
    public class UniqueValidator<TEntity> : PropertyValidator
        where TEntity : class, IEntity, new()
    {
        public UniqueValidator() : base("Girdiğiniz {PropertyName} Kayıtlarda Var Kullanılamaz.!")
        {
        }
        protected override bool IsValid(PropertyValidatorContext context)
        {
            using (var yemekyemekcontext = new Entities.Context.YemekYemekContext())
            {
                var result = yemekyemekcontext.Set<TEntity>().Where($"{context.PropertyName} == @0", context.PropertyValue).Count();
                return result == 0 ? true : false;
            }
        }
    }
}
