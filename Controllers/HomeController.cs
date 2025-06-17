
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            //ViewBag.userName = "Salih ";

            if (saat < 12)
            {
                ViewBag.selamlama = "Günaydın";
            }
            else if (saat >= 12 && saat < 18)
            {
                ViewBag.selamlama = "İyi Akşamlar";
                //ViewDate["selamlama"]="İyi Geceler"; şeklinde sözlük cinsinde de veri aktarabiliriz. Bunu kullanmak için kullanılacak yerde 
                //@ViewData["selamlama"] şeklinde yazmamız gerekiyor. Çok sayıda veri taşınacaksa bu kullanım daha iyi.
            }
            else
            {
                ViewBag.selamlama = "İyi Geceler";
            }
            //return View(model: selamlama); //model: yazmazsan model olarak geleceğini anlamaz ve index/gelen_string olarak sayfa açmaya çalışır. çünkü gönderilen değer string

            var meetingInfo = new MeetingInfo() //MeetingInfo class ının özelliklerini taşıyan bir obje,nesne oluşturduk.
            {
                Id = 1,
                Location = "Ankara, Savunma Sanayi Bakanligi 301 Uluğ Bey Kongre Salonu",
                Date = new DateTime(2025, 07, 17, 20, 0, 0),
                NumberOfPeople = 100
            };

            return View(meetingInfo); //gönderdiğin string değilse direk objeyi bu şekilde gönderebilirsin.
        }
    }
}