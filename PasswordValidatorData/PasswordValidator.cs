using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordValidatorData
{
    public class PasswordValidator
    {
        public static ValidationResults Validate(string pwd1, string pwd2)
        {
            var res = ValidatePasswordLength(pwd1);
            var res1 = ValidatePasswordMatch(pwd1, pwd2);
            var res2 = ValidateComplexity(pwd1);

            var validationResult = new ValidationResults();

            validationResult.IsValid = res.IsValid && res1.IsValid && res2.IsValid;

            if(!res.IsValid)
            {
                validationResult.Messages.Add(res.Message);
            }

            if (!res1.IsValid)
            {
                validationResult.Messages.Add(res1.Message);
            }

            if (!res2.IsValid)
            {
                validationResult.Messages.Add(res2.Message);
            }

            return validationResult;
        }

        private static ValidationResult ValidatePasswordMatch(string pwd1, string pwd2)
        {
            if (pwd1 != pwd2)
            {
                return new ValidationResult { IsValid = false, Message = "Passwords do not match" };
            }

            return new ValidationResult { IsValid = true };
        }

        private static ValidationResult ValidatePasswordLength(string pwd1)
        {
            if (pwd1.Length < 8)
            {
                return new ValidationResult { IsValid = false, Message = "Password is too short" };
            }

            return new ValidationResult { IsValid = true };
        }

        private static ValidationResult ValidateComplexity(string pwd1)
        {
            return new ValidationResult { IsValid = false, Message = "Password is too simple" };
        }
    }
}
