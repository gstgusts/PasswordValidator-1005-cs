using PasswordValidatorData;
using System;

namespace PasswordValidator_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter password: ");
            var pwd1 = Console.ReadLine();

            Console.Write("Please re-enter password: ");
            var pwd2 = Console.ReadLine();

            var res = PasswordValidator.Validate(pwd1, pwd2);

            if(!res.IsValid)
            {
                foreach (var item in res.Messages)
                {
                    Console.WriteLine(item);
                }
                return;
            }

            Console.WriteLine("Password - ok");

            // asdf asdf 

        }


    }
}
