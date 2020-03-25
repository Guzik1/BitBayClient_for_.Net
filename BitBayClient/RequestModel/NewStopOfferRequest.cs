using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    public class NewStopOfferRequest
    {
        [JsonProperty("offerType")]
        public string OfferType { get; set; }

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
