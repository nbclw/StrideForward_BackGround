using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspcoremvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public string HelloClw()
        {
            return "hello clw";
        }

        public string HelloBoy(string name)
        {
            return "hello boy " + name;
        }

        public string TestDatabase() {
            string sql = "select count(*) from user";
            var s = MySqlHelper.ExecuteScalar(sql);

            return s.ToString();
        }
    }
}
