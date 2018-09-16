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
            UserBLL userBLL = new UserBLL();
            /*
            User user = new User();
            user.UserName = "sekai6";
            user.NickName = "世界6";
            user.Pwd = "666";
            user.Forbid = 0;
            
            userBLL.AddUser(user); 
            */

            string result = "";// userBLL.GetUser(3).NickName;
            List<User> list = userBLL.GetUserList();
            foreach(User u in list)
            {
                result += u.UserName + u.NickName+"<br/>";
            }
            ViewData["result"] = result;
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
