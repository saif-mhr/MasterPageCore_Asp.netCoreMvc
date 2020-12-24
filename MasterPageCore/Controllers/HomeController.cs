using MasterPageCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterPageCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student std1 = new Student()
            {
                id = 1,
                name = "saif",
                age=26
            };

            Student std2 = new Student()
            {
                id = 2,
                name = "saif mahar",
                age = 18
            };

            Student std3 = new Student()
            {
                id = 3,
                name = "gm gaju",
                age = 24
            };

            Student std4 = new Student()
            {
                id = 4,
                name = "farooq",
                age = 21
            };

            Student std5 = new Student()
            {
                id = 4,
                name = "zeshan",
                age = 12
            };

            List<Student> std_list = new List<Student>();
            std_list.Add(std1);
            std_list.Add(std2);
            std_list.Add(std3);
            std_list.Add(std4);
            std_list.Add(std5);
            return View(std_list );
        }

        public IActionResult About(int id)
        {
            Student std1 = new Student()
            {
                id = id,
                name = "zeshan",
                age = 12
            };
            return View(std1);
        }
      
    }
}
