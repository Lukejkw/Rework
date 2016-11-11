using NUnit.Framework;
using Rework;
using System;
namespace UnitTests
{
    [TestFixture]
    public class PrettyTests
    {
        #region GetRelativeTimeBetweenDates

        [Test]
        public void GetRelativeTimeBetweenDates_GivenSameDateTime_ShouldReturnJustNow()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 1, 1, 0));
            Assert.AreEqual("just now", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given1Second_ShouldReturnJustNow()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 1, 1, 1));
            Assert.AreEqual("just now", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given61Seconds_ShouldReturn1MinuteAgo()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 1, 2, 1));
            Assert.AreEqual("1 minute ago", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given121Seconds_ShouldReturn2MinutesAgo()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 1, 3, 1));
            Assert.AreEqual("2 minutes ago", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given59Minutes_ShouldReturn59MinutesAgo()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 2, 0, 0));
            Assert.AreEqual("59 minutes ago", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given61Minutes_ShouldReturn1HourAgo()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 2, 2, 0));
            Assert.AreEqual("1 hour ago", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given23HoursAnd59MinutesAnd59Seconds_ShouldReturn23HoursAgo()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 0, 0, 1), new DateTime(2001, 1, 2, 0, 0, 0));
            Assert.AreEqual("23 hours ago", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given1DayExactly_ShouldReturnYesterday()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 1, 2));
            Assert.AreEqual("yesterday", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_GivenOver1Day_ShouldReturnYesterday()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 1, 2, 10, 0, 0));
            Assert.AreEqual("yesterday", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given2days_ShouldReturn2DaysAgo()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 1, 3));
            Assert.AreEqual("2 days ago", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given7Days_ShouldNotReturn7DaysAgo()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 1, 8));
            Assert.AreNotEqual("7 days ago", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given1week_ShouldReturn1WeekAgo()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 1, 8));
            Assert.AreEqual("1 week ago", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given16Days_ShouldReturn2WeeksAgo()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 1, 17));
            Assert.AreEqual("2 weeks ago", result);
        }

        [Test]
        public void GetRelativeTimeBetweenDates_Given32Days_ShouldReturnDateFormatted()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 2, 2));
            Assert.AreEqual("01 Jan 2001", result);
        }


        [Test]
        public void GetRelativeTimeBetweenDates_GivenDatesInWrongOrder_ShouldReturnDateFormatted()
        {
            string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 2, 2), new DateTime(2001, 1, 1));
            Assert.AreEqual("02 Feb 2001", result);
        }

        #endregion
    }
}