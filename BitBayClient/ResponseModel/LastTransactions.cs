using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Represent list of last transaction. Response data model for last transactions request.
    /// </summary>
    internal class LastTransactions
    {
        /// <summary>
        /// List of last transactions.
        /// </summary>
        [JsonProperty("items")]
        public List<LastTransactionItem> LastTransaction { get; set; }
    }

    /// <summary>
    /// Data item of transaction.
    /// </summary>
    public class LastTransactionItem
    {
        /// <summary>
        /// Transaction identificator.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Transaction time (Unix).
        /// </summary>
        [JsonProperty("t")]
        public long Timestamp { get; set; }

        /// <summary>
        /// Amount in transaction.
        /// </summary>
        [JsonProperty("a")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Transaction rate.
        /// </summary>
        [JsonProperty("r")]
        public decimal TransactionRate { get; set; }

        /// <summary>
        /// Transaction type: buy/sell.
        /// </summary>
        [JsonProperty("ty")]
        public string TransactionType { get; set; }
    }
}
