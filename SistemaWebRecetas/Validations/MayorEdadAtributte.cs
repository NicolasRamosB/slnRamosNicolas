using System.ComponentModel.DataAnnotations;

namespace SistemaWebRecetas.Validations
{

    public class MayorEdadAtributte : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int year = (int)value;

            if (year <= 18)
            {
                return new ValidationResult("Edad debe ser mayor o igual a 18 años");
            }
            return ValidationResult.Success;

        }
    }


}
