using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripe;

namespace AnimalShelter.Pages
{
    public class Payment : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}