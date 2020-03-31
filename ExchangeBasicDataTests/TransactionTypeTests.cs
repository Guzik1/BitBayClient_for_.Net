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

            Assert.AreEqual(TransactionType.BUY, type);
        }

        [Test]
        public void ParseLowerTest()
        {
            string sType = "sell";

            TransactionType type = TransactionTypeExtensions.Parse(sType);

            Assert.AreEqual(TransactionType.SELL, type);
        }

        [Test]
        public void TransactionTypeToLowerStringTest()
        {
            string type = TransactionType.SELL.ToLowerString();

            Assert.AreEqual("sell", type);
        }
    }
}