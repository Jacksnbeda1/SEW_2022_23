using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HUE04.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Picture { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (DateTime.Now.Minute%2 == 0)
            {
                this.Picture = "bild1.jpg";
            }
            else 
            {
                this.Picture = "bild2.jpg";
            }

        }

        
    }
}