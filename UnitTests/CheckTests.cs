using NUnit.Framework;
using Rework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class CheckTests
    {
        [Test]
        public void HasItems_WithNullCollection_ReturnsFalse()
        {
            var result = Check.HasItems(default(List<object>));
            Assert.False(result);
        }

        [Test]
        public void HasItems_WithEmptyCollection_ReturnsFalse()
        {
            var result = Check.HasItems(new List<object>());
            Assert.False(result);
        }

        [Test]
        public void HasItems_WithItems_ReturnsFalse()
        {
            var result = Check.HasItems(new List<object>() { new object() });
            Assert.True(result);
        }

        [Test]
        public void NotNull_WithNullObj_ReturnsFalse()
        {
            var result = Check.NotNull(default(object));

            Assert.IsFalse(result);
        }

        [Test]
        public void NotNull_WithNotNullObj_ReturnsTrue()
        {
            var result = Check.NotNull(new object());

            Assert.IsTrue(result);
        }
    }
}