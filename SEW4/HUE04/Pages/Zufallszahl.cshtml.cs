using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HUE04.Pages
{
    public class ZufallszahlModel : PageModel
    {
     public int ergebnis { get; set; }
       public void OnGet(int Min, int Max)
        {
            Random random = new Random();
            ergebnis = random.Next(Min, Max);
        }
    }
}
