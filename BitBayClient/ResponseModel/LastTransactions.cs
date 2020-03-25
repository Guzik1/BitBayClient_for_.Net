using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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

        [JsonProperty("t")]
        public long Timestamp { get; set; }

        [JsonProperty("a")]
        public decimal Amount { get; set; }

        [JsonProperty("r")]
        public decimal PositionRate { get; set; }

        [JsonProperty("ty")]
        public string TransactionType { get; set; }
    }
}
