using BitBayClient.Exceptions;
using BitBayClient.ResponseModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests.PublicApiMethod
{
    public class GetOrderbookTests
    {
        BitBayClient.BitBayClient bbClient = new BitBayClient.BitBayClient();
        Orderbook orderbook;
         
        [Test]
        public void GetOrderbookTest()
        {
            try
            {
                orderbook = bbClient.PublicTrading.GetOrderbook("BTC-USD");
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }

            Test(300);  // 300 is max of result item count, default 300.
        }

        [Test]
        public void GetLimitedOrderbookTest()
        {
            try
            {
                orderbook = bbClient.PublicTrading.GetOrderbook("BTC-USD", BitBayClient.RequestModel.OrderbookLimits.Limit10);
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }

            Test(10);
        }

        void Test(int limit)
        {
            Assert.IsNotNull(orderbook);
            Assert.AreEqual(limit, orderbook.Buy.Count);
            Assert.AreEqual(limit, orderbook.Sell.Count);
            Assert.Greater(orderbook.SeqNo, 0);
            Assert.Greater(orderbook.Buy[0].PositionRate, 0);
        }
    }
}
