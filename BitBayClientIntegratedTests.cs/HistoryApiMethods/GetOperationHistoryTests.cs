using BitBayClient.Exceptions;
using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests.HistoryApiMethods
{
    public class GetOperationHistoryTests
    {
        BitBayClient.BitBayClient bbClient = Tools.SetUp();
        OperationHistory history;

        [Test]
        public void GetOperationsHistoryTest()
        {
            OperationHistoryRequest request = new OperationHistoryRequest();
            request.BalanceCurrencies.Add("BTC");

            try
            {
                history = bbClient.History.GetOperationHistory(request);
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }

            Assert.IsNotNull(history);
            if (history.Items.Count > 0)
                Assert.AreEqual("BTC", history.Items[0].Balance.Currency);
        }
    }
}
