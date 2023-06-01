using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test3.Pages
{
    public class PrimeinputModel : PageModel
    {
        public double? Result { get; set; }
        public string? Resultstring { get; set; }

        public void OnGet()
        {
        }

        [HttpPost]
        public IActionResult OnPostCalculate(int value)
        {
            return RedirectToPage("Primefactors", new { value = value });
        }
    }
}
