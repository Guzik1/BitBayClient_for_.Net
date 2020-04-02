using BitBayClient.Exceptions;
using BitBayClient.ResponseModel;
using BitBayClientTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests.PrivateApiMethods
{
    public class GetActiveOffersTests
    {
        BitBayClient.BitBayClient bbClient = Tools.SetUp();
        List<ActiveOffer> offers;

        [Test]
        public void GetActiveOffersTest()
        {
            try
            {
                offers = bbClient.PrivateTrading.GetActiveOffer("BTC-PLN");
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }

            Assert.IsNotNull(offers);
            if (offers.Count > 0)
                Assert.AreEqual("BTC-PLN", offers[0].Market);
        }
    }
}
