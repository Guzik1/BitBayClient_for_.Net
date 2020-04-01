using BitBayClient.Exceptions;
using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using BitBayClientTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests.PrivateApiMethods
{
    public class OffersTests
    {
        BitBayClient.BitBayClient bbClient;
        decimal rate = 5m;
        decimal amount = 1m;
        string id;

        bool runTest = false;

        [SetUp]
        public void SetUp()
        {
            if (Config.IsAutorized())
                bbClient = new BitBayClient.BitBayClient(Config.PublicKey, Config.PrivateKey);
        }

        [Test]
        public void OfferManipTest()
        {
            if (runTest)
            {
                AddTestOffer();

                if (CheckOfferIsAdded())
                {
                    Assert.IsTrue(RemoveOffer());
                    Assert.IsFalse(CheckOfferIsAdded());
                }
                else
                    Assert.Fail();
            }
        }

        // TODO add offers and delete.
        void AddTestOffer()
        {
            NewOfferRequest body = new NewOfferRequest();
            NewOffer newOffer;

            body.SetLimitOffer("buy", amount, rate);

            try
            {
                newOffer = bbClient.PrivateTrading.AddNewOffer("BTC-PLN", body);
            }
            catch (FailResponseException e)
            {
                Assert.Fail(e.Errors[0].ToString());
                return;
            }

            id = newOffer.OfferId;
        }

        bool RemoveOffer()
        {
            try
            {
                return bbClient.PrivateTrading.DeleteOffer("BTC-PLN", id, ExchangeBasicData.TransactionType.BUY, rate);
            }
            catch (FailResponseException e)
            {
                if(e.Errors.Count > 0)
                    Assert.Fail(e.Errors[0].ToString());

                Assert.Fail();
                return false;
            }
        }

        bool CheckOfferIsAdded()
        {
            List<ActiveOffer> offers;

            try
            {
                offers = bbClient.PrivateTrading.GetActiveOffer("BTC-PLN");
            }
            catch (FailResponseException e)
            {
                Assert.Fail(e.Errors[0].ToString());
                return false;
            }

            Assert.IsNotNull(offers);
            int index = offers.FindIndex(n => (n.Rate == rate && n.Id == id && n.StartAmount == amount));

            if (index != -1)
            {
                Assert.AreEqual("BTC-PLN", offers[index].Market);
                StringAssert.AreEqualIgnoringCase("Buy", offers[index].OfferType);
                Assert.AreEqual(id, offers[index].Id);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
