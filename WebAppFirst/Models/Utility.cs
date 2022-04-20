using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirst.Models
{
    public class Utility
    {
        public static string Checker(string name)
        {
            int temprture = Int32.Parse(name);
            int threshold = 37;
            string msg;
            if (temprture > threshold)
            {
             return  msg= "You have fever see the doctor!";//ViewBag.Msg = "You have fever see the doctor!";
            }
            else
            return   msg = "You have not  fever, you do not need to see the doctor!";
            //System.Console.WriteLine("Box opened");
        }
    }
}
