using System;
using System.ComponentModel.DataAnnotations;

namespace FormAndLayout.Models
{
    // Custom validation attribute to validate email matching with Id
    public class EmailValidation : ValidationAttribute
    {
        // Overriding the IsValid method with the correct access modifier
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var myClass = validationContext.ObjectInstance as MyClass;

            if (myClass != null)
            {
                var id = myClass.Id;
                var email = value?.ToString();

                // Construct the expected email from Id
                string expectedEmail = $"{id}@student.aiub.edu";

                if (email != null && email.Equals(expectedEmail, StringComparison.OrdinalIgnoreCase))
                {
                    // Return success if the email matches the Id format
                    return ValidationResult.Success;
                }
                else
                {
                    // Return validation failure if the email doesn't match
                    return new ValidationResult("Email does not match the Id.");
                }
            }

            // Return default validation failure if model is not properly cast
            return new ValidationResult("Invalid model instance.");
        }
    }
}

