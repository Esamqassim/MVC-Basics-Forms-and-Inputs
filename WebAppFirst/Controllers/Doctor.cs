using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirst.Models;

namespace WebAppFirst.Controllers
{
    public class Doctor : Controller
    {
        public IActionResult FeverCheck()
        {
            // ViewBag.Msg = "Information from Doctor Controller";
            
            return View();
        }
        //To form
        [HttpPost]
        public IActionResult FeverCheck(string quantity)
        {
            string val = Utility.Checker(quantity);
            ViewBag.Msg = val;
            /* int temprture= Int32.Parse(quantity);//This process is used when u do not have a model
            int threshold = 37;
            if (temprture > threshold) {
                ViewBag.Msg = "You have fever see the doctor!";
                  }
            else
                ViewBag.Msg = "You have not  fever, you do not need to see the doctor!";*/
            //return RedirectToAction("Index");
            return View();
        }
    }
}
