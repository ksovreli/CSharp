using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Logic_Restaurant_Razor_App.Pages
{
    public class CountriesModel : PageModel
    {
        public string Countries { get; set; } = "Countries";
        public void OnGet()
        {
        }
    }
}
