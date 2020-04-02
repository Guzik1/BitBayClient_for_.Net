using BitBayClient.Exceptions;
using BitBayClient.ResponseModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests.PublicApiMethod
{
    public class GetLastTransactionsTests
    {
        BitBayClient.BitBayClient bbClient = new BitBayClient.BitBayClient();
        List<LastTransactionItem> lastTransactions;

        [Test]
        public void GetLastTransactionsDefaultTest()
        {
            int limit = 10; // default

            try
            {
                lastTransactions = bbClient.PublicTrading.GetLastTransactions("BTC-USD");
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }

            Test(limit);
        }

        [Test]
        public void GetLastTransactionsWithLimitTest()
        {
            int limit = 50;
            try
            {
                lastTransactions = bbClient.PublicTrading.GetLastTransactions("BTC-USD", limit);
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }

            Test(limit);
        }


        [Test]
        public void GetLastTransactionsWithLimitAndDateTest()
        {
            int limit = 50;
            DateTimeOffset dto = new DateTimeOffset(DateTime.Now.AddMinutes(-1));

            try
            {
                lastTransactions = bbClient.PublicTrading.GetLastTransactions("BTC-USD", limit, dto.ToUnixTimeSeconds());
            }
            catch (FailResponseException e)
            {
                Tools.HandlingErrors(e);
                return;
            }

            Assert.IsNotNull(lastTransactions);
            Assert.LessOrEqual(limit, lastTransactions.Count);
            StringAssert.AreNotEqualIgnoringCase("", lastTransactions[0].Id);
            Assert.Greater(lastTransactions[0].Timestamp, dto.ToUnixTimeSeconds());
            Assert.Greater(lastTransactions[0].TransactionRate, 0);
            Assert.Greater(lastTransactions[0].Amount, 0);
            Assert.IsTrue(lastTransactions[0].TransactionType == "Buy" || lastTransactions[0].TransactionType == "Sell");
        }

        void Test(int limit)
        {
            Assert.IsNotNull(lastTransactions);
            Assert.AreEqual(limit, lastTransactions.Count);
            StringAssert.AreNotEqualIgnoringCase("", lastTransactions[0].Id);
            Assert.Greater(lastTransactions[0].Timestamp, 0);
            Assert.Greater(lastTransactions[0].TransactionRate, 0);
            Assert.Greater(lastTransactions[0].Amount, 0);
            Assert.IsTrue(lastTransactions[0].TransactionType == "Buy" || lastTransactions[0].TransactionType == "Sell");
        }
    }
}
