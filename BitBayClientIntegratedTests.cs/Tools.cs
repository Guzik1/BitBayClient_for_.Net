using BitBayClient.Exceptions;
using BitBayClientTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientIntegratedTests
{
    internal static class Tools
    {
        internal static void HandlingErrors(FailResponseException e)
        {
            if (e.Errors.Count > 0)
                Assert.Fail(e.Errors[0].ToString());

            Assert.Fail();
        }

        internal static BitBayClient.BitBayClient SetUp()
        {
            if (Config.IsAutorized())
                return new BitBayClient.BitBayClient(Config.PublicKey, Config.PrivateKey);

            throw new Exception();
        }
    }
}
