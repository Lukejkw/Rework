using System.Text;
using System.Text.RegularExpressions;

namespace Rework
{
    public static class Strings
    {
        public static string Slugify(this string phrase)
        {
            if (!Check.NotNull(phrase))
                return string.Empty;

            string str = phrase.ToLowerInvariant().RemoveAccent();
            str = Regex.Replace(str, @"[^a-z0-9\s-]", ""); // Remove all non valid chars
            str = Regex.Replace(str, @"\s+", " ").Trim(); // convert multiple spaces into one space
            str = Regex.Replace(str, @"\s", "-"); // //Replace spaces by dashes

            return str;
        }

        public static string RemoveAccent(this string txt)
        {
            byte[] bytes = Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return Encoding.ASCII.GetString(bytes);
        }
    }
}