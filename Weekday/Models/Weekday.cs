using System;
using System.Collections.Generic;

namespace Weekday.Models
{
    public class Weekday
    {
        public DateTime Date { get; set; }

        public Weekday(DateTime date)
        {
            Date = date;
        }
    }
}
