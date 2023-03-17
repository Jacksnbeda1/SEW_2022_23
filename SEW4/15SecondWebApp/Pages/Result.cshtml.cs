using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _15SecondWebApp.Pages
{
    public class ResultModel : PageModel
    {
        public double Result { get; set; }
        public string Calculation { get; set; }
        public void OnGet(double result, string calculation)
        {
            Result = result;
            Calculation = calculation;
        }
    }
}
