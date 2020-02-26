using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ExchangeBasicData;

namespace BitBayClient.RequestModel
{
    public class NewOfferStop
    {
        [JsonIgnoreAttribute]
        public TransactionType Type { get; set; }
        [JsonProperty("offerType")]
        public string OfferType => Type.ToLowerString();

        public float Amount { get; set; }

        [JsonProperty("stopRate")]
        public float StopRate { get; set; }

        public float Rate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Balances Balances { get; set; }

        [JsonProperty("ignoreInvalidStopRate")]
        public bool IgnoreInvalidStopRate { get; set; }
    }
}
