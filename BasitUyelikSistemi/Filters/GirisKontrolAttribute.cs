using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BasitUyelikSistemi.Filters
{
    public class GirisKontrolAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetString("giris") == null)
            {
                context.Result = new RedirectToActionResult("Index", "Giris", "");
            }
        }
    }
}
