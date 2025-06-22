
using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpPost]
        public IActionResult Apply(UserInfo Model)
        {
            Repository.CreateUser(Model);
            ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            return View("thanks", Model);
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
    }
}