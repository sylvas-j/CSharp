using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mathsquareweb.Models;

namespace Mathsquareweb.Controllers
{
    public class CalController : Controller
    {
        [HttpGet]
        public ActionResult add()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult add(string firstnumb, string secondnumb)
        {
            // this section accept the number entered by the users and the processing continues
            double numbone = int.Parse(firstnumb);
            double numbtwo = int.Parse(secondnumb);

            if(numbone < 0 || numbtwo < 0){
               string result = "You entered a negative number. \nPlease enter postive number.";
               ViewBag.result = result;
            }else{
                numbone = Math.Sqrt(int.Parse(firstnumb));
                numbtwo = Math.Sqrt(int.Parse(secondnumb));

                if(numbone > numbtwo){
                    string result = "Ok! " + numbone + " Is your first number root greater than your second number root " + numbtwo;
                    ViewBag.result = result;
                }else if(numbone == numbtwo){
                    string result = "Please enter another numbers the two roots are equal " + numbone + " and " + numbtwo;
                    ViewBag.result = result;
                }else{
                    string result = "Ok! " + numbtwo + " Is your second number root greater than your first number root " + numbone;
                    ViewBag.result = result;
                }; // end second if statement
                
                
            };//end first if statement
            
            return View();
        }
    }
}