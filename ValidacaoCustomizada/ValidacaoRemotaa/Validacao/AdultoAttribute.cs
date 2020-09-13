using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ValidacaoRemotaa.Models;

namespace ValidacaoRemotaa.Validacao
{
    public class AdultoAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Pessoas pessoas = (Pessoas)validationContext.ObjectInstance;

            if(pessoas.Idade < 18)
            {
                return new ValidationResult("Apenas Adultos podem se cadastrar");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
