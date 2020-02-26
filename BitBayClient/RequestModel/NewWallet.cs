using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;
using Newtonsoft.Json;

namespace BitBayClient.RequestModel
{
    public class NewWallet
    {
        [JsonIgnore]
        public Currency Currency { get; set; }
        [JsonProperty("currency")]
        public string CurrencyString { get; set; }

        [JsonIgnore]
        public CurrencyType Type { get; set; }
        [JsonProperty("type")]
        public string TypeString { get => Type.ToString(); }

        public string Name { get; set; }
    }
}
