using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;
using Newtonsoft.Json;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// New wallet data model for <see cref="Wallet.CreateNewWallet(string, string, WalletType)"/> request.
    /// </summary>
    public class NewWalletRequest
    {
        /// <summary>
        /// Currence code.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Type of wallet: crypto or fiat.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Wallet name.
        /// </summary>
        public string Name { get; set; }

        internal NewWalletRequest(string currency, string type, string name)
        {
            Currency = currency;
            Type = type;
            Name = name;
        }
    }
}
