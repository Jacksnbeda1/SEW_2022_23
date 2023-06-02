using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Numerics;

namespace ggTWeb.Pages
{
    public class ggtinputModel : PageModel
    {
        public double? Result { get; set; }
        public string? Resultstring { get; set; }

        public void OnGet()
        {
        }

        [HttpPost]
        public IActionResult OnPostCalculate(int value, int value2)
        {
          
            return RedirectToPage("ggtcalculate", new {value, value2});

        }

    }
}


