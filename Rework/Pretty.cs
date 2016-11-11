using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rework
{
    /// <summary>
    /// A set of helpful helper functions for getting pretty dates
    /// </summary>
    public static class Pretty
    {
        /// <summary>
        /// Returns a string representing the relative time between 2 DateTime values.
        /// I started out using this as a base, but rewrote some of it: http://www.dotnetperls.com/pretty-date
        /// </summary>
        /// <param name="startDate">The start date</param>
        /// <param name="endDate">The end date</param>
        /// <param name="dateFormat">The format of the date if the difference is greater than 1 month</param>
        /// <returns>A string representing the relative time between the two dates</returns>
        public static string GetRelativeTimeBetweenDates(DateTime startDate, DateTime endDate, string dateFormat = "dd MMM yyyy")
        {
            const int MAXIMUM_DAYS_IN_MONTH = 31;
            const int ONE_MINUTE = 60;
            const int TWO_MINUTES = 120;
            const int ONE_HOUR = 3600;
            const int TWO_HOURS = 7200;
            const int ONE_DAY = 86400;
            const int ONE_WEEK = 7;
            TimeSpan interval = endDate.Subtract(startDate);
            double differenceInDays = interval.TotalDays;
            int differenceInDaysRoundedUpToNearestOne = (int)Math.Round(differenceInDays);
            int differenceInSeconds = (int)interval.TotalSeconds;
            string relativeTime = "";
            if (differenceInDays >= 0 && differenceInDaysRoundedUpToNearestOne < MAXIMUM_DAYS_IN_MONTH)
            {
                if (differenceInDays < 1)
                {
                    if (differenceInSeconds < ONE_MINUTE)
                    {
                        relativeTime = "just now";
                    }
                    else if (differenceInSeconds < TWO_MINUTES)
                    {
                        relativeTime = "1 minute ago";
                    }
                    else if (differenceInSeconds < ONE_HOUR)
                    {
                        relativeTime = $"{Math.Floor((double)differenceInSeconds / ONE_MINUTE)} minutes ago";
                    }
                    else if (differenceInSeconds < TWO_HOURS)
                    {
                        relativeTime = "1 hour ago";
                    }
                    else if (differenceInSeconds < ONE_DAY)
                    {
                        relativeTime = $"{Math.Floor((double)differenceInSeconds / ONE_HOUR)} hours ago";
                    }
                }
                else if (differenceInDays >= 1 && differenceInDays < 2)
                {
                    DateTime yesterday = endDate.AddDays(-1);
                    relativeTime = startDate.Date == yesterday.Date ? "yesterday" : "2 days ago";
                }
                else if (differenceInDaysRoundedUpToNearestOne < ONE_WEEK)
                {
                    relativeTime = $"{differenceInDaysRoundedUpToNearestOne} day{(differenceInDays > 1 ? "s" : "")} ago";
                }
                else if (differenceInDaysRoundedUpToNearestOne < MAXIMUM_DAYS_IN_MONTH)
                {
                    double numberOfWeeks = Math.Floor((double)differenceInDaysRoundedUpToNearestOne / ONE_WEEK);
                    relativeTime = $"{numberOfWeeks} week{(numberOfWeeks > 1 ? "s" : "")} ago";
                }
                else
                {
                    DateTime oneMonthAgo = endDate.AddMonths(-1);
                    if (startDate.Year == oneMonthAgo.Year && startDate.Month == oneMonthAgo.Month)
                    {
                        relativeTime = "last month";
                    }
                }

            }

            if (string.IsNullOrEmpty(relativeTime))
            {
                relativeTime = startDate.ToString(dateFormat);
            }
            return relativeTime;
        }
    }
}