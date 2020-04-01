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
        BitBayClient.BitBayClient bbClient;
        List<ActiveOffer> offers;

        [SetUp]
        public void SetUp()
        {
            if (Config.IsAutorized())
                bbClient = new BitBayClient.BitBayClient(Config.PublicKey, Config.PrivateKey);
        }

        [Test]
        public void GetActiveOffersTest()
        {
            try
            {
                offers = bbClient.PrivateTrading.GetActiveOffer("BTC-PLN");
            }
            catch (FailResponseException e)
            {
                Assert.Fail(e.Errors[0].ToString());
                return;
            }

            Assert.IsNotNull(offers);
            if (offers.Count > 0)
                Assert.AreEqual("BTC-PLN", offers[0].Market);
        }
    }
}
