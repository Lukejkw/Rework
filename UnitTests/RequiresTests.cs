using NUnit.Framework;
using Rework;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class RequiresTests
    {
        [Test]
        public void NotNull_WithNullObject_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Require.NotNull<object>(null));
        }

        [Test]
        public void NotNull_WithValidObject_ShouldNotThrow()
        {
            Assert.DoesNotThrow(() => Require.NotNull(new object()));
        }

        [Test]
        public void NotNullOrEmptyOrWhitespace_WithEmptyString_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentNullException>(() => Require.NotNullOrEmptyOrWhitespace(string.Empty));
        }

        [Test]
        public void NotNullOrEmptyOrWhitespace_WithValidString_ShouldNotThrow()
        {
            Assert.DoesNotThrow(() => Require.NotNullOrEmptyOrWhitespace("valid string"));
        }

        [Test]
        public void NotNullOrEmpty_WithNullIEnumerable_ShouldThrowNullArumentException()
        {
            List<object> list = null;
            Assert.Throws<ArgumentNullException>(() => Require.NotNullOrEmpty(list));
        }

        [Test]
        public void NotNullOrEmpty_WithEmptyIEnumerable_ShouldThrowArumentException()
        {
            var list = new List<object>();
            Assert.Throws<ArgumentException>(() => Require.NotNullOrEmpty(list));
        }

        [Test]
        public void NotNullOrEmpty_WithPopulatedIEnumerable_ShouldNotThrow()
        {
            var list = new List<object>() { new object(), new object() };
            Assert.DoesNotThrow(() => Require.NotNullOrEmpty(list));
        }
    }
}