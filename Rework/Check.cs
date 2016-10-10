using System;
using System.Collections.Generic;
using System.Linq;

namespace Rework
{
    public static class Check
    {
        public static bool HasItems<T>(IEnumerable<T> collection)
        {
            return NotNull(collection) && collection.Count() > 0;
        }

        public static bool NotNull(object thing)
        {
            return thing != null;
        }
    }
}