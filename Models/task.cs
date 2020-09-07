using System;

namespace myCalendar.Models
{
    public class task
    {
        public int Id {get; set;}

        public string Title {get; set;}

        public string Notes { get; set; }

        public bool Important { get; set; }

        public DateTime? Date { get; set; } // ? means optional. So we can create a task W/O a date
    
    }
}