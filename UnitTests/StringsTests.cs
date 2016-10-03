using NUnit.Framework;
using Rework;

namespace UnitTests
{
    [TestFixture]
    public class StringsTests
    {
        [Test]
        public void Slugify_WithEmptyString_ShouldReturnEmptyString()
        {
            var result = string.Empty.Slugify();

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
    }
}