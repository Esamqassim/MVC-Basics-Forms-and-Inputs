using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()//index file
        {
            return View();
        }
        //added 
        
    }
}
