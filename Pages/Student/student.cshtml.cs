using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autenticacion.Pages.Student

{
    [Authorize]
    public class studentModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
