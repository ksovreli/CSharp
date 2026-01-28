using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages
{
    public class RestaurantModel : PageModel
    {
        public string Name { get; set; } = "Step Restaurant";
        public void OnGet()
        {
        }
    }
}
