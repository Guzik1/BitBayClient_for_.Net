using BitBayClient.Exceptions;
using BitBayClient.ResponseModel;
using BitBayClientTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests.PrivateStopTradingMethods
{
    public class GetActiveStopOffersTests
    {
        BitBayClient.BitBayClient bbClient = Tools.SetUp();
        List<ActiveStopOffer> offers;

        [Test]
        public void GetActiveOffersTest()
        {
            try
            {
                offers = bbClient.PrivateStopTrading.GetActiveStopOffer("BTC-PLN");
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
            }

            Assert.IsNotNull(offers);
            if (offers.Count > 0)
            {
                Assert.AreEqual("BTC-PLN", offers[0].Market);
            }
        }
    }
}
