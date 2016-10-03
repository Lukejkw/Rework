using System;
using System.Collections.Generic;
using System.Linq;

namespace Rework
{
    /// <summary>
    /// A set of handy helper functions for checking if objects are null.
    /// </summary>
    public class Requires
    {
        /// <summary>
        /// Checks if the object is null. If it is, an exception is thrown
        /// </summary>
        /// <param name="obj">The object to test</param>
        public static void NotNull(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException();
        }

        /// <summary>
        /// Checks if a Collection is Null or contains no items. Throws either a ArgumentNullException or an ArgumentException
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        public static void NotNullOrEmpty<T>(IEnumerable<T> items)
        {
            if (items == null)
                throw new ArgumentNullException();
            if (items.Count() <= 0)
                throw new ArgumentException();
        }

        /// <summary>
        /// Checks if a string is Null, Empty, Or whitespace or throws an argument null exception
        /// </summary>
        /// <param name="str">The string to test</param>
        public static void NotNullOrEmptyOrWhitespace(string str)
        {
            if (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str))
                throw new ArgumentNullException();
        }
    }
}