using NUnit.Framework;
using Rework;
using System;

namespace UnitTests
{
    [TestFixture]
    public class RangeTests
    {
        #region Before

        [Test]
        public void Before_WithDateBefore_ReturnsTrue()
        {
            var dateToCheck = new DateTime(2016, 01, 01);
            var dateToUse = new DateTime(2016, 01, 02);
            bool result = Range.Before(dateToCheck, dateToUse);

            Assert.IsTrue(result);
        }

        [Test]
        public void Before_WithDateAfter_ReturnsFalse()
        {
            var dateToCheck = new DateTime(2016, 01, 02);
            var dateToUse = new DateTime(2016, 01, 01);
            bool result = Range.Before(dateToCheck, dateToUse);

            Assert.IsFalse(result);
        }

        [Test]
        public void Before_WithSameDate_ReturnsFalse()
        {
            var dateToCheck = new DateTime(2016, 01, 01);
            var dateToUse = new DateTime(2016, 01, 01);
            bool result = Range.Before(dateToCheck, dateToUse);

            Assert.IsFalse(result);
        }

        [Test]
        public void Before_WithDateBeforeWithTime_ReturnsTrue()
        {
            var dateToCheck = new DateTime(2016, 1, 1, 1, 1, 10);
            var dateToUse = new DateTime(2016, 1, 2, 1, 1, 1);
            bool result = Range.Before(dateToCheck, dateToUse);

            Assert.IsTrue(result);
        }

        #endregion

        #region Between

        [Test]
        public void Between_WithDateBetween_ReturnsTrue()
        {
            bool res = Range.Between(
                new DateTime(2016, 01, 1),
                new DateTime(2016, 01, 3),
                new DateTime(2016, 01, 2));

            Assert.IsTrue(res);
        }

        [Test]
        public void Between_WithDateBeforeStart_ReturnsFalse()
        {
            bool res = Range.Between(
                new DateTime(2016, 01, 1),
                new DateTime(2016, 01, 3),
                new DateTime(2015, 12, 1));

            Assert.IsFalse(res);
        }

        [Test]
        public void Between_WithDateAfterEnd_ReturnsFalse()
        {
            bool res = Range.Between(
                new DateTime(2016, 01, 1),
                new DateTime(2016, 01, 3),
                new DateTime(2017, 1, 1));

            Assert.IsFalse(res);
        }

        [Test]
        public void Between_WithDateEqualToStart_ReturnsFalse()
        {
            bool res = Range.Between(
                new DateTime(2016, 01, 1),
                new DateTime(2016, 01, 3),
                new DateTime(2016, 01, 1));

            Assert.IsFalse(res);
        }

        [Test]
        public void Between_WithDateEqualToEnd_ReturnsFalse()
        {
            bool res = Range.Between(
                new DateTime(2016, 01, 1),
                new DateTime(2016, 01, 3),
                new DateTime(2016, 01, 3));

            Assert.IsFalse(res);
        }

        [Test]
        public void Between_WithIntBetween_ReturnsTrue()
        {
            bool res = Range.Between(0, 2, 1);

            Assert.IsTrue(res);
        }

        [Test]
        public void Between_WithIntBeforeStart_ReturnsFalse()
        {
            bool res = Range.Between(1, 3, 0);

            Assert.IsFalse(res);
        }

        [Test]
        public void Between_WithIntAfterEnd_ReturnsFalse()
        {
            bool res = Range.Between(1, 2, 3);

            Assert.IsFalse(res);
        }

        [Test]
        public void Between_WithIntEqualToStart_ReturnsFalse()
        {
            bool res = Range.Between(1, 3, 1);

            Assert.IsFalse(res);
        }

        [Test]
        public void Between_WithIntEqualToEnd_ReturnsFalse()
        {
            bool res = Range.Between(1, 3, 3);

            Assert.IsFalse(res);
        }

        [Test]
        public void Between_WithDoubleBetween_ReturnsTrue()
        {
            bool res = Range.Between(0d, 2d, 1d);

            Assert.IsTrue(res);
        }

        [Test]
        public void Between_WithDoubleBeforeStart_ReturnsFalse()
        {
            bool res = Range.Between(1d, 3d, 0d);

            Assert.IsFalse(res);
        }

        [Test]
        public void Between_WithDoubleAfterEnd_ReturnsFalse()
        {
            bool res = Range.Between(1d, 2d, 3d);

            Assert.IsFalse(res);
        }

        [Test]
        public void Between_WithDoubleEqualToStart_ReturnsFalse()
        {
            bool res = Range.Between(1d, 3d, 1d);

            Assert.IsFalse(res);
        }

        [Test]
        public void Between_WithDoubleEqualToEnd_ReturnsFalse()
        {
            bool res = Range.Between(1d, 3d, 3d);

            Assert.IsFalse(res);
        }

        #endregion

        #region After

        [Test]
        public void After_WithDateAfter_ReturnsTrue()
        {
            bool res = Range.After(
                new DateTime(2016, 01, 02),
                new DateTime(2016, 01, 01));

            Assert.IsTrue(res);
        }

        [Test]
        public void After_WithDateBefore_ReturnsFalse()
        {
            bool res = Range.After(
                new DateTime(2016, 01, 01),
                new DateTime(2016, 01, 02));

            Assert.IsFalse(res);
        }

        [Test]
        public void After_WithDateSame_ReturnsFalse()
        {
            bool res = Range.After(
                new DateTime(2016, 01, 01),
                new DateTime(2016, 01, 01));

            Assert.IsFalse(res);
        }

        #endregion
    }
}