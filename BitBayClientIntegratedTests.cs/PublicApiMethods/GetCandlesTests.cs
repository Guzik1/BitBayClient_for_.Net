using BitBayClient.Exceptions;
using BitBayClient.ResponseModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests.PublicApiMethod
{
    public class GetCandlesTests
    {
        BitBayClient.BitBayClient bbClient = new BitBayClient.BitBayClient();
        Candles candles;

        [Test]
        public void GetCandlesDefaultTest()
        {
            try
            {
                candles = bbClient.PublicTrading.GetCandlesData("BTC-PLN", ExchangeBasicData.CandleResolution.m15, 1577869200000, 1577872800000);
            }
            catch (FailResponseException e)
            {
                if (e.Errors.Count > 0)
                    Assert.Fail(e.Errors[0].ToString());
                else
                    Assert.Fail(e.Message);

                return;
            }

            Assert.IsNotNull(candles);
            Assert.AreEqual(ExchangeBasicData.CandleResolution.m15, candles.Resoluton);
            Assert.AreEqual(5, candles.CandlesList.Count);
            Assert.Greater(candles.CandlesList[1577869200000].HighestRate, 0);
            Assert.Greater(candles.CandlesList[1577869200000].OpenRate, 0);
        }
    }
}
