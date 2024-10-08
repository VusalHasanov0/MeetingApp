using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models; 

namespace MeetingApp.Controllers
{
    public class HomeController : Controller 
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            // ViewBag.Selamlama =  saat> 12 ? "Iyi Gunler" : "Gunaydin";
            // ViewBag.UserName = "Vusal";

            ViewData["Selamlama"] = saat> 12 ? "Iyi Gunler" : "Gunaydin";
            int UserCount = Repository.Users.Where(i=>i.WillAttend==true).Count();
            // ViewData["UserName"] = "Vusal";

            var meetingInfo = new MeetingInfo()
            {
                Id =1 ,
                Location = "Istanbul",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = UserCount
            };
            return View(meetingInfo);
        }
    }
}