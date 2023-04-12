using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HUE05.Pages
{
    public class ZeitrechnerModel : PageModel
    {
        public string? Erg { get; set; }
        public decimal HmAuf { get; set; }

        public decimal HmAb { get; set; }

        public decimal KmHo { get; set; }

        public decimal HoDi { get; set; }

        public decimal hours { get; set; }
        public decimal minutes { get; set; }

        [HttpPost]
        public IActionResult OnPostRechner(decimal HmAuf, decimal HmAb, decimal KmHo)
        {
            this.HmAuf = HmAuf / 300;
            this.HmAb = HmAb/500;
            this.KmHo = KmHo/4;
            this.HoDi = this.HmAuf + this.HmAb;

            if (HoDi < this.KmHo)
            {
                HoDi = this.HoDi / 2;
            }
            else
            {
                KmHo = this.KmHo / 2;
            }
            hours = HoDi + KmHo;

            minutes = (hours - Math.Truncate(hours))*60;            //von Raphael Völker

            if (minutes > 45)
            {
                minutes = 0;
                hours = hours++;
            }else if (minutes > 30)
            {
                minutes = 45;
            }else if(minutes > 15)
            {
                minutes = 30;
            }else if (minutes > 0)
            {
                minutes = 15;
            }

            Erg = $"{Math.Truncate(hours)} Stunden und {minutes} Minuten";

            return Page();
        }
    }
}
