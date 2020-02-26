using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ExchangeBasicData;

namespace BitBayClient.ResponseModel
{
    public class LastTransactions
    {
        [JsonProperty("items")]
        public List<LastTransactionItem> LastTransaction { get; set; }

        public DateTime RequestTime { get; set; }
    }

    public class LastTransactionItem
    {
        public string Id { get; set; }

        public DateTime Date { get; set; }

        [JsonProperty("t")]
        public long Timestamp { set { Date = Converters.Date.Convert(value); } }

        [JsonProperty("a")]
        public decimal AmoutInPosition { get; set; }

        [JsonProperty("r")]
        public decimal PositionRate { get; set; }

        public TransactionType Type { get; set; }

        [JsonProperty("ty")]
        public string TransactionType { set { Type = TransactionTypeExtensions.Parse(value); } }
    }
}
