using NUnit.Framework;
using Rework;
using System;

namespace UnitTests
{
    [TestFixture]
    public class CryptoTests
    {
        #region GetRelativeTimeBetweenDates

        //Verified against https://secure.ogone.com/ncol/test/testsha.asp

        [Test]
        public void ToSHA_SHA1_ShouldMatchValue()
        {
            Assert.AreEqual("A9993E364706816ABA3E25717850C26C9CD0D89D", "abc".ToSHA(Crypto.SHA_Type.SHA1));
        }

        [Test]
        public void ToSHA_SHA256_ShouldMatchValue()
        {
            Assert.AreEqual("BA7816BF8F01CFEA414140DE5DAE2223B00361A396177A9CB410FF61F20015AD", "abc".ToSHA(Crypto.SHA_Type.SHA256));
        }

        [Test]
        public void ToSHA_SHA512_ShouldMatchValue()
        {
            Assert.AreEqual("DDAF35A193617ABACC417349AE20413112E6FA4E89A97EA20A9EEEE64B55D39A2192992A274FC1A836BA3C23A3FEEBBD454D4423643CE80E2A9AC94FA54CA49F", "abc".ToSHA(Crypto.SHA_Type.SHA512));
        }

        #endregion
    }
}