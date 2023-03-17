using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _15SecondWebApp.Pages
{
    public double? Result { get; set; }
    public string Calculation { get; set; }
    public void OnGet()
    {
    }
    [HttpPost]
    public IActionResult OnPostCalculate(double subtrahent, double minuent)
    {
        Result = subtrahent - minuent;
        Calculation = $"{subtrahent} + {minuent} = {Result}";
        return Page();      // wir bleiben auf der gleichen Seite
    }
}
