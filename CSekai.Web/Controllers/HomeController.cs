using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSekai.Web.Models;
using CSekai.SYS.Entity;
using CSekai.SYS.BLL;

namespace CSekai.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            User user = new User();
            user.UserName = "sekai5";
            user.NickName = "世界5";
            user.Pwd = "13579";
            user.Forbid = 0;
            UserBLL userBLL = new UserBLL();
            userBLL.AddUser(user); 
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
