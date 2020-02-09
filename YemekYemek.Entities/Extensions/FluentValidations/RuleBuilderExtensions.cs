using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekYemek.Entities.InterFaces;

namespace YemekYemek.Entities.Extensions.FluentValidations
{
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilderOptions<TEntity,object> IsUnique<TEntity>(this IRuleBuilder<TEntity, object> ruleBuilder)
            where TEntity:class,IEntity,new()
        {
            return ruleBuilder.SetValidator(new UniqueValidator<TEntity>());
        }
    }
}
