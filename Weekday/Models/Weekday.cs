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

        public String GetWeekday()
        {
            Dictionary<int, string> days = new Dictionary<int, string>()
            {
                { 1, "Monday" },
                { 2, "Tuesday" },
                { 3, "Wednesday" },
                { 4, "Thursday" },
                { 5, "Friday" },
                { 6, "Saturday" },
                { 7, "Sunday" }
            };
            return days[(int)Date.DayOfWeek];
        }
    }
}
