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
        public List<TransactionHistoryItem> Transactions { get; set; }

        [JsonProperty("nextPageCursor")]
        public string NextPageCursor { get; set; }

        public TransactionHistory() { }

        internal TransactionHistory(int totalRows, List<TransactionHistoryItem> transactions, string nextPageCursor)
        {
            TotalRows = totalRows;
            Transactions = transactions;
            NextPageCursor = nextPageCursor;
        }
    }

    public class TransactionHistoryItem
    {
        public string Id { get; set; }

        public Pair CurrencyPair { get; set; }

        public DateTime Time { get; set; }
        
        public decimal Amount { get; set; }

        public decimal Rate { get; set; }

        public TransactionType InitializedBy { get; set; }

        public bool WasTaker { get; set; }

        public TransactionType UserActionType { get; set; }

        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        [JsonProperty("commissionValue")]
        public decimal CommissionValue { get; set; }
    }
}
