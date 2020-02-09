using FluentValidation;
using System;
using System.Windows.Forms;
using YemekYemek.Entities.InterFaces;

namespace YemekYemek.Entities.Tools
{
    public static class ValidatorTools
    {
        public static bool Validate(IValidator validator, IEntity entity)
        {
            bool result = true;

            var validationResult = validator.Validate(entity);
            if (!validationResult.IsValid)
            {
                string message = null;
                foreach (var error in validationResult.Errors)
                {
                    message += error.ErrorMessage + Environment.NewLine;
                }
                MessageBox.Show(message);
                result = false;
            }
            return result;
        }
    }
}