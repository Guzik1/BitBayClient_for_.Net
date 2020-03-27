using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClientTests
{
    internal static class Config
    {
        internal static string ApiTradingUrl => ApiUrl + "trading/";

        public static string ApiUrl { get; } = "https://api.bitbay.net/rest/";

        internal static string PublicKey { get; set; } = "";

        internal static string PrivateKey { get; set; } = "";
    }
}
