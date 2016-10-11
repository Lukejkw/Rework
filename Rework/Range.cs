using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rework
{
    public static class Range
    {
        /// <summary>
        /// Checks if a date is before another date
        /// </summary>
        /// <param name="dateToCheck">The date to use when checking</param>
        /// <param name="dateToCheckAgainst">The date your want to check against</param>
        /// <returns></returns>
        public static bool Before(DateTime dateToCheck, DateTime dateToCheckAgainst)
        {
            return dateToCheck < dateToCheckAgainst;
        }

        /// <summary>
        /// Checks if a date falls between 2 other dates
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="valueToCheck"></param>
        /// <returns></returns>
        public static bool Between(DateTime start, DateTime end, DateTime valueToCheck)
        {
            return valueToCheck > start && valueToCheck < end;
        }

        /// <summary>
        /// Checks id a double falls between 2 other doubles
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="valueToCheck"></param>
        /// <returns></returns>
        public static bool Between(double start, double end, double valueToCheck)
        {
            return valueToCheck > start && valueToCheck < end;
        }

        /// <summary>
        /// Checks if an int falls between 2 other ints
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="valueToCheck"></param>
        /// <returns></returns>
        public static bool Between(int start, int end, int valueToCheck)
        {
            return valueToCheck > start && valueToCheck < end;
        }

        /// <summary>
        /// Checks if a date falls after another date
        /// </summary>
        /// <param name="dateToCheck"></param>
        /// <param name="dateToCheckAgainst"></param>
        /// <returns></returns>
        public static bool After(DateTime dateToCheck, DateTime dateToCheckAgainst)
        {
            return dateToCheck > dateToCheckAgainst;
        }
    }
}