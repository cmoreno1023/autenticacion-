using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autenticacion.Pages.Teacher
{
    [Authorize]
    public class teacherModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
