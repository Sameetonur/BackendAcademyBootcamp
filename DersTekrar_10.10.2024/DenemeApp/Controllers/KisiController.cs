using DenemeApp.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace DenemeApp.Controllers
{
    public class KisiController : Controller
    {

        public ActionResult Index()
        {
            Kisi kisi = new Kisi
            {
                Ad = "Samet",
                Soyad = "Önür",
                Hakkımda = "Düzce Ünversitesi Bilgisayara Programcılığı mezunuyum. Kendimi geliştirmek için şuanda Acunmedya Akademide BackEnd Uzamanlığı eğitimi alıyorum",
                KisiFotoUrl = "/Resims/DSCF6216.JPG",            
            };

            return View(kisi);
        }

    }
}
