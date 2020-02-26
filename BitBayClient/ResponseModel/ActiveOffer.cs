using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using BitBayClient.Converters;
using CurrencyPair;
using ExchangeBasicData;

namespace BitBayClient.ResponseModel
{ 
    public class ActiveOffer
    {
        [JsonProperty("items")]
        [JsonConverter(typeof(SingleOrArrayConverter<ActiveOfferItem>))]
        public List<ActiveOfferItem> ActiveOffers { get; set; }
    }

    public class ActiveOfferItem
    {
        [JsonIgnoreAttribute]
        public Pair Pair { get; set; }
        public string Market { set { Pair = new Pair(value); } }

        public TransactionType Type { get; set; }
        [JsonProperty("offerType")]
        public string OfferType { set { Type = TransactionTypeExtensions.Parse(value); } }

        public string Id { get; set; }

        [JsonProperty("currentAmount")]
        public decimal CurrentAmount { get; set; }

        [JsonProperty("lockedAmount")]
        public decimal LockedAmount { get; set; }
        
        [JsonProperty("rate")]
        public decimal Rate { get; set; }

        [JsonProperty("startAmount")]
        public decimal StartAmount { get; set; }

        [JsonIgnoreAttribute]
        public DateTime OpenDate { get; set; }
        public long Time { set { OpenDate = Converters.Date.Convert(value); } }

        [JsonProperty("postOnly")]
        public bool PostOnly { get; set; }

        [JsonIgnoreAttribute]
        public OfferType OfferMode { get; set; }
        public string Mode { set { OfferMode = OfferTypeExtension.Parse(value); } }

        [JsonProperty("receivedAmount")]
        public decimal ReceivedAmount { get; set; }

        [JsonProperty("firstBalanceId")]
        public string FirstBalanceId { get; set; }

        [JsonProperty("secondBalanceId") ]
        public string SecondBalanceId { get; set; }
    }
}
