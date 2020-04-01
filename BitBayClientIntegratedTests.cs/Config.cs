using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientTests
{
    internal static class Config
    {
        internal static string PublicKey = "";

        internal static string PrivateKey = "";

        internal static bool IsAutorized()
        {
            if (string.IsNullOrEmpty(PublicKey) || string.IsNullOrEmpty(PrivateKey))
            {
                throw new Exception("Client is unautorized, add client keys to config.");
            }

            return true;
        }
    }
}
