using BitBayClient.Exceptions;
using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using BitBayClientTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests.PrivateStopTradingMethods
{
    public class StopOfferHandlingTests
    {
        BitBayClient.BitBayClient bbClient = Tools.SetUp();
        string offerId;
        decimal amount = 1m;
        decimal rate = 5m;
        decimal stopRate = 8m;

        bool runTest = false;

        [Test]
        public void StopOfferManipTest()
        {
            if (runTest && Config.IsAutorized())
            {
                AddNewStopOffer();
                if (CheckStopOfferIdAdded())
                {
                    Assert.IsTrue(RemoveStopOffer());
                    Assert.IsFalse(CheckStopOfferIdAdded());
                }
                else
                    Assert.Fail();
            }
            else
                Assert.IsTrue(true);
        }

        void AddNewStopOffer()
        {
            NewStopOfferRequest body = new NewStopOfferRequest();
            body.SetStopLimitOffer("BUY", amount, stopRate, rate);

            try
            {
                offerId = bbClient.PrivateStopTrading.AddNewStopOffer("BTC-PLN", body);
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }
        }

        bool CheckStopOfferIdAdded()
        {
            List<ActiveStopOffer> offers;

            try
            {
                offers = bbClient.PrivateStopTrading.GetActiveStopOffer("BTC-PLN");
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return false;
            }

            if(offers.Count > 0)
            {
                int index = offers.FindIndex(n => n.Id == offerId);
                return index != -1;
            }

            return false;
        }

        bool RemoveStopOffer()
        {
            try
            {
                return bbClient.PrivateStopTrading.DeleteStopOffer("BTC-PLN", offerId);
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return false;
            }
        }
    }
}
