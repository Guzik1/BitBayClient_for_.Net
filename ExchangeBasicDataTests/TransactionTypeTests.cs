using NUnit.Framework;
using ExchangeBasicData;

namespace ExchangeBasicDataTests
{
    [TestFixture]
    public class TransactionTypeTests
    {
        [Test]
        public void ParseTest()
        {
            string sType = "Buy";

            TransactionType type = TransactionTypeExtensions.Parse(sType);

            Assert.AreEqual(TransactionType.Buy, type);
        }

        [Test]
        public void ParseLowerTest()
        {
            string sType = "sell";

            TransactionType type = TransactionTypeExtensions.Parse(sType);

            Assert.AreEqual(TransactionType.Sell, type);
        }

        [Test]
        public void TransactionTypeToLowerStringTest()
        {
            string type = TransactionType.Sell.ToLowerString();

            Assert.AreEqual("sell", type);
        }
    }
}