using NUnit.Framework;
using Rework;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    [TestFixture]
    public class CollectionsTests
    {
        [Test]
        public void HasItems_GivenACollection_ReturnsInDifferentOrder()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var shuffled = numbers.Shuffle();
            Assert.AreNotEqual(numbers, shuffled);
        }

        [Test]
        public void HasItems_GivenACollection_SameNumberOfItems()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> shuffled = numbers.Shuffle().ToList<int>();
            Assert.AreEqual(numbers.Count, shuffled.Count);
        }

        [Test]
        public void HasItems_GivenACollection_ContainsSameItems()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> shuffled = numbers.Shuffle().ToList<int>();
            Assert.AreEqual(numbers.OrderBy(x => x), shuffled.OrderBy(x => x));
        }
    }
}