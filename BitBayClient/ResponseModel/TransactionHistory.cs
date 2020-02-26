using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;
using ExchangeBasicData;

namespace BitBayClient.ResponseModel
{
    public class TransactionHistory
    {
        [JsonProperty("totalRows")]
        public int TotalRows { get; set; }

        [JsonProperty("items")]
        public List<HistoryTransactionItem> Transactions { get; set; }

        [JsonProperty("nextPageCursor")]
        public string NextPageCursor { get; set; }
    }

    public class HistoryTransactionItem
    {
        public string Id { get; set; }

        public Pair CurrencyPair { get; set; }
        public string Market { set { CurrencyPair = new Pair(value); } }

        public DateTime ExecuteDate { get; set; }
        public long Time { set { ExecuteDate = Converters.Date.Convert(value); } }
        
        public decimal Amount { get; set; }

        public decimal Rate { get; set; }

        public TransactionType InitialBy { get; set; }
        [JsonProperty("initializedBy")]
        public string InitialByString { set { InitialBy = TransactionTypeExtensions.Parse(value); } }

        [JsonProperty("wasTaker")]
        public bool WasTaker { get; set; }

        public TransactionType UserActionType { get; set; }
        [JsonProperty("userAction")]
        public string UserActionTypeString { set { UserActionType = TransactionTypeExtensions.Parse(value); } }

        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        [JsonProperty("commissionValue")]
        public decimal CommissionValue { get; set; }
    }
}
