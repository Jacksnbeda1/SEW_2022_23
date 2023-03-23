using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HUE04.Pages
{
    public class ZeitBisZumSchulschluss2023Model : PageModel
    {
        public string erg { get; set; }
        public void OnGet()
        {
        }
        [HttpPost]
        public IActionResult OnPostSchulschluss(DateTime Schulschluss)
        {
            int remaining = Schulschluss.DayOfYear - DateTime.Now.DayOfYear;
            erg =$"{remaining.ToString()} Tage = {(remaining*24).ToString()}Stunden = {(remaining*3600).ToString()} Minuten = {(remaining * 3600*60).ToString()} Sekunden";
            return Page();
        }
    } 
}

