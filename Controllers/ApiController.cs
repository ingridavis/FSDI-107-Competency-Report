

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using myCalendar.Models;
using System;
using System.Linq; 


namespace myCalendar.Controllers
{
    public class ApiController : Controller
    {   
        private DataContext database;
        public ApiController(DataContext db)
        {
            this.database = db;
        }
            // API is a programming interface

         public IActionResult Tasks() // This action is to retrieve from the database
        {
            
            /*  object literal
            
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
                Notes = "Get milk next time",
                Important = false,
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
            list.Add(t4);  */

            var list = database.TasksTable.ToList();
            return Json(list);
        }
        [HttpPost]
        public IActionResult CreateTask( [FromBody] task theTask ) //post
        {
            database.TasksTable.Add(theTask);
            database.SaveChanges();

            return Json(theTask);
        }
    }
}
