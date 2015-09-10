using CustomValidatorExample.Models;
using System.ComponentModel.DataAnnotations;

namespace CustomValidatorExample.Validators
{
    public class CustomTitleValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {            
            var employee = (Employee)validationContext.ObjectInstance;

            if (employee.IsActive)
            {
                if (value == null || string.IsNullOrEmpty(value.ToString()))
                {
                    // Oops!
                    return new ValidationResult(validationContext.DisplayName + " is required when the employee is active.");
                }                
            }

            // Ok!
            return ValidationResult.Success;            
        }
    }
}