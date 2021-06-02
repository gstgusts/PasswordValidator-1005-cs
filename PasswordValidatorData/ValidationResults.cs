using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordValidatorData
{
    public class ValidationResults
    {
        public bool IsValid { get; set; }

        public List<string> Messages { get; set; } = new List<string>();
    }
}
