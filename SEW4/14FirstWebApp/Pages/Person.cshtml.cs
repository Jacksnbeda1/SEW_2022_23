using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _14FirstWebApp.Pages
{
    public class PersonModel : PageModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IList<string> Mails { get; set; }

        public void OnGet()
        {
            this.FirstName = "Jakob";
            this.LastName = "Jehle";
            this.Mails = new List<string>();
            this.Mails.Add("jakob.jehle@josephinum.at");
            this.Mails.Add("bioerdbeeren@biohof_jehle.at");
        }
    }
}
