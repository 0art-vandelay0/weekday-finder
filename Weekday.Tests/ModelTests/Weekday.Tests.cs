using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Weekday.Models;

namespace Weekday.Models.Tests
{
    [TestClass]
    public class WeekdayTests
    {
        [TestMethod]
        public void WeekdayConstuctor_CreatesInstanceOfWeekday_Weekday()
        {
            DateTime date = new DateTime(2023, 7, 12);
            Weekday weekdayDate = new Weekday(date);
            Assert.AreEqual(typeof(Weekday), weekdayDate.GetType());
        }
    }
}