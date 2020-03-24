using BitBayClient.Converters;
using BitBayClient.RequestModel;
using CurrencyPair;
using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    public class ActiveStopOffers
    {
        [JsonProperty("items")]
        [JsonConverter(typeof(SingleOrArrayConverter<ActiveStopOfferItem>))]
        public List<ActiveStopOfferItem> ActiveOffer { get; set; }
    }

    public class ActiveStopOfferItem
    {
        public string Id { get; set; }

        [JsonProperty("operationId")]
        public string OperationId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        public string Market { get; set; }

        public decimal Amount { get; set; }

        public decimal Rate { get; set; }

        [JsonProperty("stopRate")]
        public decimal StopRate { get; set; }

        public string Status { get; set; }

        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        public string Mode { get; set; }

        public Balances Balances { get; set; }

        [JsonProperty("createdAt")]
        public long Time { get; set; }

        public List<object> Flags { get; set; }

    }
}
