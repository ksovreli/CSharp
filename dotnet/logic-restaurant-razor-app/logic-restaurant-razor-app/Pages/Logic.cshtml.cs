using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages
{
    public class LogicModel : PageModel
    {
        public int dateTime { get; set; }
        public char letter { get; set; }

        public void OnGet()
        {
            dateTime = DateTime.Now.DayOfYear;
            Random random = new Random();
            letter = (char)random.Next('A', 'Z');
        }
    }
}
