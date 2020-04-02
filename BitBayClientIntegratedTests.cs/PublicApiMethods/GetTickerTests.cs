using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using BitBayClient;
using BitBayClient.ResponseModel;
using BitBayClient.Exceptions;

namespace BitBayClientIntegratedTests.PublicApiMethod
{
    public class GetTickerTests
    {
        BitBayClient.BitBayClient bbClient = new BitBayClient.BitBayClient();

        [Test]
        public void GetOneTickerTest()
        {
            Ticker ticker;

            try
            {
                ticker = bbClient.PublicTrading.GetTicker("BTC-USD");
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }

            Assert.IsNotNull(ticker);
            Assert.IsTrue(ticker.HighestBid > 0);
            Assert.IsTrue(ticker.LowestAsk > 0);
            Assert.IsTrue(ticker.Rate > 0);
            Assert.IsTrue(ticker.Market.First.Currency == "BTC");
            Assert.IsTrue(ticker.Market.First.MinOffer > 0);
            Assert.IsTrue(ticker.Market.Second.Currency == "USD");
            Assert.IsTrue(ticker.Market.Second.MinOffer > 0);
            Assert.IsTrue(ticker.Market.Code == "BTC-USD");
        }

        [Test]
        public void GetAllTickerTest()
        {
            Dictionary<string, Ticker> ticker;

            try
            {
                ticker = bbClient.PublicTrading.GetAllTicker();
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }

            Assert.IsNotNull(ticker);
            Assert.IsTrue(ticker.Count > 1);
        }
    }
}
