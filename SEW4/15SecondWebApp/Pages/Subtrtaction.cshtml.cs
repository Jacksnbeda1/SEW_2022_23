using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _15SecondWebApp.Pages
{
    public class SubtrtactionModel : PageModel
    {
        public double? Result { get; set; }
        public string Calculation { get; set; }
        public void OnGet()
        {
        }
        [HttpPost]
        public IActionResult OnPostCalculate(double subtrahend, double minuend)
        {
            Result = subtrahend - minuend;
            Calculation = $"{subtrahend} - {minuend} = {Result}";
            return Page();      // wir bleiben auf der gleichen Seite
        }
        [HttpPost]
        public IActionResult OnPostCalculateAndRedirect(double subtrahend1, double minuend1)
        {
            double summe = subtrahend1 - minuend1;
            return RedirectToPage("Result", new { result = summe, calculation = $"{subtrahend1} - {minuend1} = " , source = "Subtrtaction" });
        }
    }
   
}
