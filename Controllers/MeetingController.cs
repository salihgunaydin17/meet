
using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpPost]
        public IActionResult Apply(UserInfo Model)
        {
            if (ModelState.IsValid) // UserInfo modelinden required alanların hepsi kontrol ediliyor. Boş yok ise hepsi true geliyorsa bu blok çalışıyor.
            {
                Repository.CreateUser(Model);
                ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
                return View("thanks", Model);
            }
            else
            {
                return View(Model); // ModelState geçerli değilse, yani required alanlardan biri boş ise, model tekrar view'a gönderiliyor.
            }

        }
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        public IActionResult list()
        {
            return View(Repository.Users);
        }
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}