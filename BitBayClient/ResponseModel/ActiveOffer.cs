using BitBayClient.Converters;
using CurrencyPair;
using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    public class ActiveOffers
    {
        [JsonProperty("items")]
        [JsonConverter(typeof(SingleOrArrayConverter<ActiveOfferItem>))]
        public List<ActiveOfferItem> ActiveOffer { get; set; }
    }

    public class ActiveOfferItem
    {
        public string Market { get; set; }

        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        public string Id { get; set; }

        [JsonProperty("currentAmount")]
        public decimal CurrentAmount { get; set; }

        [JsonProperty("lockedAmount")]
        public decimal LockedAmount { get; set; }

        [JsonProperty("rate")]
        public decimal Rate { get; set; }

        [JsonProperty("startAmount")]
        public decimal StartAmount { get; set; }

        public long Time { get; set; }

        [JsonProperty("postOnly")]
        public bool PostOnly { get; set; }

        public string Mode { get; set; }

        [JsonProperty("receivedAmount")]
        public decimal ReceivedAmount { get; set; }

        [JsonProperty("firstBalanceId")]
        public string FirstBalanceId { get; set; }

        [JsonProperty("secondBalanceId")]
        public string SecondBalanceId { get; set; }

    }
}
