using BitBayClient.Exceptions;
using BitBayClient.ResponseModel;
using BitBayClientTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests.PrivateApiMethods
{
    public class GetCommissionAndConfigTests
    {
        BitBayClient.BitBayClient bbClient = Tools.SetUp();
        CommissionAndConfig config;

        [Test]
        public void GetCommsionAndConfigTest()
        {
            try
            {
                config = bbClient.PrivateTrading.GetCommissionsAndConfiguration("BTC-PLN");
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }

            Assert.IsNotNull(config);
            StringAssert.AreNotEqualIgnoringCase("", config.First.BalanceId);
            Assert.Greater(config.Buy.Commissions.Maker, 0.001m);
            Assert.Less(config.Buy.Commissions.Maker, 0.045m);
        }
    }
}
