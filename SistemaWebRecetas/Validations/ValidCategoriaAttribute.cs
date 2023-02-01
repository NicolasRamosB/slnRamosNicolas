﻿using System.ComponentModel.DataAnnotations;

namespace SistemaWebRecetas.Validations
{
    public class ValidCategoriaAttribute : ValidationAttribute
    {
        public ValidCategoriaAttribute()
        {
            ErrorMessage = "La categoria solo puede ser DESAYUNO";
        }
        public override bool IsValid(object value)
        {
            string categoria = (string)value;
            if (categoria.ToUpper() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
