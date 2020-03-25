using CurrencyPair;
using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    public class TransactionHistory
    {
        [JsonProperty("totalRows")]
        public int TotalRows { get; set; }

        [JsonProperty("items")]
        public List<TransactionHistoryItem> Transactions { get; set; }

        [JsonProperty("nextPageCursor")]
        public string NextPageCursor { get; set; }
    }

    public class TransactionHistoryItem
    {
        public string Id { get; set; }

        public string Market { get; set; }

        public long Time { get; set; }

        public decimal Amount { get; set; }

        public decimal Rate { get; set; }

        [JsonProperty("initializedBy")]
        public string InitialBy { get; set; }

        [JsonProperty("wasTaker")]
        public bool WasTaker { get; set; }

        [JsonProperty("userAction")]
        public string UserActionType { get; set; }

        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        [JsonProperty("commissionValue")]
        public decimal CommissionValue { get; set; }
    }
}
