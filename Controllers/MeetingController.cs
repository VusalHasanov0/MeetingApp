using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                Repository.CreateUser(userInfo);
                ViewBag.UserCount = Repository.Users.Where(i=>i.WillAttend==true).Count();
                return View("Thanks",userInfo);
            }
            else {
                return View(userInfo);
            }
        }
        [HttpGet]
        public IActionResult List()
        {
            return View(Repository.Users);
        }

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

        
    }
}