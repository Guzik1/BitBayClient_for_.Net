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
            {
                string errors = "";
                for (int i = 0; i < e.Errors.Count; i++)
                    errors += e.Errors[i].ToString() + " / ";

                Assert.Fail(errors);
            }


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
