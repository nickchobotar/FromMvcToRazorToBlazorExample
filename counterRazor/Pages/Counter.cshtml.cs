using Microsoft.AspNetCore.Mvc.RazorPages;

namespace counterRazor
{
    public class CounterModel : PageModel
    {
        public int Number { get; set; }

        public void OnPost()
        {
            int number = int.Parse(Request.Form["number"]);
            Number = number + 1;
        }
    }
}

 
