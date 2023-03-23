using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _15SecondWebApp.Pages
{
    public class AdditionModel : PageModel
    {
        public double? Result { get; set; }
        public string Calculation { get; set; }
        public void OnGet()
        {
        }
        [HttpPost]
        public IActionResult OnPostCalculate(double summand1, double summand2)
        {
            Result = summand1 +  summand2;
            Calculation = $"{summand1} + {summand2} = {Result}";
            return Page();      // wir bleiben auf der gleichen Seite
        }
        [HttpPost]
        public IActionResult OnPostCalculateAndRedirect(double summand1, double summand2)
        {
            double summe = summand1 + summand2;
            return RedirectToPage("Result", new {result=summe, calculation=$"{summand1} + {summand2} = ", source = "Addition"});
        }
    }
}