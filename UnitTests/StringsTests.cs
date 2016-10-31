using NUnit.Framework;
using Rework;

namespace UnitTests
{
    [TestFixture]
    public class StringsTests
    {
        #region Slugify

        [Test]
        public void Slugify_WithEmptyString_ShouldReturnEmptyString()
        {
            var result = string.Empty.Slugify();

            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void Slugify_WithNull_ShouldReturnEmptyString()
        {
            string str = null;
            var result = str.Slugify();

            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void Slugify_WithSlugifiedString_ShouldReturnSameString()
        {
            var result = "luke-is-awesome".Slugify();

            Assert.AreEqual("luke-is-awesome", result);
        }

        [Test]
        public void Slugify_WithNonSlugifiedString_ShouldReturnSlugifiedString()
        {
            var result = "luke is awesome".Slugify();

            Assert.AreEqual("luke-is-awesome", result);
        }

        [Test]
        public void Slugify_WithNonSlugifiedStringWithInvalidChars_ShouldReturnSlugifiedString()
        {
            var result = "lukè is àwesome".Slugify();

            Assert.AreEqual("luke-is-awesome", result);
        }

        [Test]
        public void Slugify_WithNonSlugifiedStringWithInvalidPunctuation_ShouldReturnSlugifiedString()
        {
            var result = "luke,is,awesome".Slugify();

            Assert.AreEqual("lukeisawesome", result);
        }

        #endregion

        #region Truncate

        [Test]
        public void Truncate_WithEmptyString_ShouldReturnEmptyString()
        {
            var result = string.Empty.Truncate(10);

            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void Truncate_WithNullString_ShouldReturnNullWithNoException()
        {
            var result = default(string).Truncate(10);

            Assert.AreEqual(null, result);
        }

        [Test]
        public void Truncate_WithLongString_ShouldTruncateString()
        {
            var result = "Some long string".Truncate(6);

            Assert.AreEqual("Some l", result);
        }

        [Test]
        public void Truncate_WithShortString_ShouldJustReturnTheString()
        {
            var result = "Some long string".Truncate(16);

            Assert.AreEqual("Some long string", result);
        }

        #endregion
    }
}