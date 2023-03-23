using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _15SecondWebApp.Pages
{
    public class CollatzModel : PageModel
    {
        public string Calculation { get; set; }

        public void OnGet()
        {
        }
        [HttpPost]
        public IActionResult OnPostCalculate(int zahl)
        {
            int erg = 0;
            while (zahl != 1)
            {
                zahl = erg;

                if (zahl % 2 == 0)
                {
                    erg = zahl / 2;

                    Calculation += erg.ToString();

                }
                else
                {
                    erg = zahl * 3 + 1;
                    Calculation += erg.ToString();
                }
            }
            return Page();
        }

    }
}
