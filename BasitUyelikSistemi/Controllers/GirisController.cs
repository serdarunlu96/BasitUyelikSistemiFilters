using BasitUyelikSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasitUyelikSistemi.Controllers
{
    public class GirisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                if(kullanici.KullaniciAdi == "ali" && kullanici.Parola == "123")
                {
                    HttpContext.Session.SetString("giris", "ali");

                    return RedirectToAction("Index", "Home", new { login = "Giris Basarili"});
                }
                else
                {
                    ModelState.AddModelError("", "Kullanici adi ya da parola yanlis!");
                }
            }
            return View();
        }
    }
}
