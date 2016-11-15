using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rework
{
    /// <summary>
    /// Contains useful, reusable Methods for dealing with collections
    /// </summary>
    public static class Collections
    {
        /// <summary>
        /// Takes a generic collection of items and shuffles them for you
        /// </summary>
        /// <typeparam name="T">The type of object in the collection</typeparam>
        /// <param name="items">Self referencing extension method parameter</param>
        /// <returns>The collection in a different order</returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> items)
        {
            return from item in items orderby Guid.NewGuid() ascending select item;
        }
    }
}
