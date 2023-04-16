using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _15SecondWebApp.Pages
{
    public class CollatzModel : PageModel
    {
        public void OnGet()
        {
        }

        [HttpPost]
        public IActionResult OnPostCalculateAndRedirect(int colnumb)
        {
            List<int> colnumbList = new List<int>();
            colnumbList.Add(colnumb);

            while (colnumb != 1)
            {
                if (colnumb > 0)
                {
                    if (colnumb % 2 == 0)
                    {
                        colnumb = colnumb / 2;
                        colnumbList.Add(colnumb);
                    }
                    else
                    {
                        colnumb = colnumb * 3 + 1;
                        colnumbList.Add(colnumb);
                    }
                }
            }

            string colnummererg = String.Join(", ", colnumbList.ToArray());             // Zum trennen der Daten der Liste mit einem Beistrich
            colnummererg = colnummererg + ", 4, 2, 1, ...";
            // eduitlab#1teacher
            return RedirectToPage("Collatz-Result", new { result = colnummererg });
        }
    }
}
