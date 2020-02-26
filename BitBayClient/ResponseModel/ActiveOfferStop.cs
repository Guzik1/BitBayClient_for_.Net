using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using CurrencyPair;
using ExchangeBasicData;
using BitBayClient.RequestModel;

namespace BitBayClient.ResponseModel
{
    public class ActiveOfferStop
    {
        public List<OfferItem> Offers { get; set; }
    }

    public class OfferItem {
        public string Id { get; set; }

        [JsonProperty("operationId")]
        public string OperationId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        public Pair Pair { get; set; }
        public string Market { set { Pair = new Pair(value); } }

        public decimal Amount { get; set; }

        public decimal Rate { get; set; }

        [JsonProperty("stopRate")]
        public decimal StopRate { get; set; }

        public string Status { get; set; }

        public TransactionType Type { get; set; }
        [JsonProperty("offerType")]
        public string OfferType { set { Type = TransactionTypeExtensions.Parse(value); } }

        public OfferType OfferMode { get; set; }
        public string Mode { set { OfferMode = OfferTypeExtension.Parse(value); } }

        public Balances Balances { get; set; }

        public DateTime CratedTime { get; set; }
        [JsonProperty("createdAt")]
        public long Time { set { CratedTime = Converters.Date.Convert(value); } }

        public List<object> Flags { get; set; }
    }
}
