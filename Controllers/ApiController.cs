

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using myCalendar.Models;
using System;

namespace myCalendar.Controllers
{
    public class ApiController : Controller
    {
            // API is a programming interface

         public IActionResult Tasks()
        {
            var list = new List<task>();

            var t1 = new task();
            t1.Id =1;
            t1.Title = "First task";
            t1.Notes = "This is the first task on my super calender sys";
            t1.Important = true;
            t1.Date = DateTime.Now;
            list.Add(t1);

            var t2 = new task()
            {
                Id =2,
                Title = "Get Milk",
                Important = false,
                Notes = "Get milk next time",
                Date = DateTime.Now
            };
            list.Add(t2);

              var t3 = new task()
            {
                Id =3,
                Title = "Walk dog",
                Important = false,
                Notes = "Play fetch",
                Date = DateTime.Today.AddDays(1)
            };
            list.Add(t3);

              var t4 = new task()
            {
                Id =4,
                Title = "Make dinner",
                Important = false,
                Notes = "Make lasagna",
                Date = DateTime.Now
            };
            list.Add(t4);

            return Json(list);

        }
        
    }
}