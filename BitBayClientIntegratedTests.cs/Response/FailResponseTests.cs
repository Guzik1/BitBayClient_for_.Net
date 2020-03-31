using NUnit.Framework;
using BitBayClient;
using BitBayClient.Exceptions;

namespace BitBayClientTests.Response
{
    public class FailResponseTests
    {
        [Test]
        public void FailResponseTest()
        {
            BitBayClient.BitBayClient bbc = new BitBayClient.BitBayClient();

            try
            {
                bbc.PublicTrading.GetTicker("EURO-USD");

                Assert.Fail();
            }
            catch (FailResponseException e)
            {
                Assert.AreEqual(1, e.Errors.Count);
                Assert.AreEqual(ErrorMessage.TICKER_NOT_FOUND, e.Errors[0]);
            }
        }
    }
}