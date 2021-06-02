using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PasswordValidatorData;

namespace PasswordValidator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Message { get; set; }

        [BindProperty]
        public string[] Messages { get; set; } = new string[0];

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //var a = "aaaa";
            //ViewData["key1"] = a;

            Name = "Gusts";
        }

        public void OnPost(string password1, string password2)
        {
            var res = PasswordValidatorData.PasswordValidator.Validate(password1, password2);

            if (!res.IsValid)
            {
                Message = "";

                foreach (var item in res.Messages)
                {
                    Message += "<p>" + item + "</p>";
                }

                Messages = res.Messages.ToArray();

                return;
            } else
            {
                Message = "Password is ok";
            }
        }
    }
}
