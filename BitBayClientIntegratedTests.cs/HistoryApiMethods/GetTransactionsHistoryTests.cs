using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using BitBayClient.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests.HistoryApiMethods
{
    public class GetTransactionsHistoryTests
    {
        BitBayClient.BitBayClient bbClient = Tools.SetUp();
        TransactionHistory history;

        [Test]
        public void GetOperationsHistoryTest()
        {
            TransactionHistoryRequest request = new TransactionHistoryRequest();
            request.Markets.Add("BTC-PLN");

            try
            {
                history = bbClient.History.GetTransactionHistory(request);
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }

            Assert.IsNotNull(history);
            if (history.Transactions.Count > 0)
                Assert.AreEqual("BTC-PLN", history.Transactions[0].Market);
        }

    }
}
