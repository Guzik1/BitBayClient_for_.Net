using NUnit.Framework;
using ExchangeBasicData;

namespace ExchangeBasicDataTests
{
    [TestFixture]
    public class offerTypeTests
    {
        [Test]
        public void ParseTest()
        {
            string sType = "Limit";

            OfferType type = OfferTypeExtension.Parse(sType);

            Assert.AreEqual(OfferType.LIMIT, type);
        }

        [Test]
        public void ParseLowerWithDashTest()
        {
            string sType = "stop-limit";

            OfferType type = OfferTypeExtension.Parse(sType);

            Assert.AreEqual(OfferType.STOP_LIMIT, type);
        }

        [Test]
        public void ParseLowerWithLowerDashTest()
        {
            string sType = "Stop_limit";

            OfferType type = OfferTypeExtension.Parse(sType);

            Assert.AreEqual(OfferType.STOP_LIMIT, type);
        }


        [Test]
        public void OffertTypeToLowerStringTest()
        {
            OfferType type = OfferType.STOP_LIMIT;

            string sType = type.ToLowerString();

            Assert.AreEqual("stop-limit", sType);
        }
    }
}