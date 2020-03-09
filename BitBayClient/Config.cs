using System;

namespace BitBayClient
{
    internal class Config
    {
        internal string ApiTradingUrl => ApiUrl + "trading/";

        internal string ApiTradingStopUrl => ApiTradingUrl + "stop/";

        internal string ApiBalancesUrl => ApiUrl + "balances/BITBAY/balance/";

        internal string ApiUrl { get; } = "https://api.bitbay.net/rest/";

        internal string PublicKey { get; set; } = "";

        internal string PrivateKey { get; set;  } = "";
    }
}
