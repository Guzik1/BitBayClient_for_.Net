using BitBayClient.Exceptions;
using BitBayClient.ResponseModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests.PublicApiMethod
{
    public class GetMarektStatsTests
    {
        BitBayClient.BitBayClient bbClient = new BitBayClient.BitBayClient();

        [Test]
        public void GetMarketStatsTest()
        {
            Stats stats;

            try
            {
                stats = bbClient.PublicTrading.GetMarketStats("BTC-USD");
            }
            catch (FailResponseException e)
            {
                Assert.Fail(e.Errors[0].ToString());
                return;
            }

            Assert.IsNotNull(stats);
            StringAssert.AreEqualIgnoringCase("BTC-USD", stats.Code);
            Assert.IsTrue(stats.AvarageRate > 0);
            Assert.IsTrue(stats.HighestRate > 0);
            Assert.IsTrue(stats.LowestRate > 0);
            Assert.IsTrue(stats.Volume > 0);
        }

        [Test]
        public void GetAllMarketStatsTest()
        {
            Dictionary<string, Stats> stats;

            try
            {
                stats = bbClient.PublicTrading.GetAllMarketStats();
            }
            catch (FailResponseException e)
            {
                Assert.Fail(e.Errors[0].ToString());
                return;
            }

            Assert.IsNotNull(stats);
            Assert.Greater(stats.Count, 1);
            StringAssert.AreEqualIgnoringCase("BTC-USD", stats["BTC-USD"].Code);
            Assert.IsTrue(stats["ETH-GBP"].AvarageRate > 0);
        }
    }
}
