using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rework
{
    public static class Strings
    {
        private const string Elipsis = "&hellip;";

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

        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            return value.Length <= maxLength
                ? value
                : value.Substring(0, maxLength);
        }

        public static string TruncateAtWord(this string text, int maxCharacters, string trailingStringIfTextCut = Elipsis)
        {
            // Check that string is not null and long enough
            if (text == null || (text = text.Trim()).Length <= maxCharacters)
                return text;

            // Get length of trailing string if cut
            int trailLength = trailingStringIfTextCut.StartsWith("&") ? 1 : trailingStringIfTextCut.Length;

            // Get max length and find last space word
            int length = maxCharacters - trailLength;
            maxCharacters = length >= 0 ? length : 0;
            int lastSpaceIndex = text.LastIndexOf(" ", maxCharacters, StringComparison.Ordinal);

            if (lastSpaceIndex >= 0)
            {
                // All good, return substring
                return text.Substring(0, lastSpaceIndex) + trailingStringIfTextCut;
            }
            return string.Empty;
        }

        public static string CapitalizeWord(string word)
        {
            if (String.IsNullOrWhiteSpace(word))
                return word;

            word = word.Trim().ToLowerInvariant();

            return $"{char.ToUpper(word.First())}{word.Substring(1)}";
        }

        public static string CapitalizeSentence(string sentence)
        {
            if (String.IsNullOrWhiteSpace(sentence))
                return sentence;

            string[] words = sentence.Trim().Split(' ');
            return String.Join(" ", words.Select(CapitalizeWord));
        }
    }
}