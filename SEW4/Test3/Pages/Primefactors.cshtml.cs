using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test3.Pages
{
    public class PrimefactorsModel : PageModel
    {
        public string Result { get; set; }

        public void OnGet(double value)
        {
            for (int i = 2; i <= value; i++)
            {
                while (value % i == 0)
                {
                    Result += i + " * ";
                    value /= i;
                }
            }
        }
    }
}