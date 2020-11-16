using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab8GetToKnowClassmates.Controllers
{
    public class StudentsController : Controller
    {
        //[Area("Students")]
        //public IActionResult Index()    
        //{
        //    return View("ViewStudents");
        //}
        public IActionResult ViewStudents()
        {
            return View();
        }
        
        public IActionResult ViewStudents(string userInput)
        {
            return View(userInput);
        }

        public IActionResult ChooseStudent()
        {
            return View();
        }
    }
}
