using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ExchangeBasicData;

namespace BitBayClient.RequestModel
{
    public class NewOffer
    {
        public float Amount { get; set; }

        public float Rate { get; set; }

        public float Price { get; set; }

        [JsonIgnoreAttribute]
        public TransactionType Type { get; set; }

        [JsonProperty("offerType")]
        public string OfferType => Type.ToLowerString();

        [JsonIgnoreAttribute]
        public OfferType OfferMode { get; set; }
        public string Mode => OfferMode.ToLowerString();

        [JsonProperty("postOnly")]
        public bool PostOnly { get; set; }

        [JsonProperty("fillOrKill")]
        public bool FillOrKill { get; set; }

        [JsonProperty("immediateOrCancel")]
        public bool ImmediateOrCancel { get; set; }

        [JsonProperty("firstBalanceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstBalanceId { get; set; }

        [JsonProperty("secondBalanceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SecondBalanceId { get; set; }
    }
}
