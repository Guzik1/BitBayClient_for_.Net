using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;
using Newtonsoft.Json;

namespace BitBayClient.RequestModel
{
    public class NewWalletRequest
    {
        public string Currency { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        internal NewWalletRequest(string currency, string type, string name)
        {
            Currency = currency;
            Type = type;
            Name = name;
        }
    }
}
