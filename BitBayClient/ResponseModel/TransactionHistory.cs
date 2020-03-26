using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Data model on get transaction history request, return from <see cref="BitBayClient.GetTransactionHistory(RequestModel.TransactionHistoryRequest)"/>
    /// </summary>
    public class TransactionHistory
    {
        /// <summary>
        /// Number of rows in resault.
        /// </summary>
        [JsonProperty("totalRows")]
        public int TotalRows { get; set; }

        /// <summary>
        /// List of transacton history items.
        /// </summary>
        [JsonProperty("items")]
        public List<TransactionHistoryItem> Transactions { get; set; }

        /// <summary>
        /// Cursor to next pager of resault, use in request to get next pages.
        /// </summary>
        [JsonProperty("nextPageCursor")]
        public string NextPageCursor { get; set; }
    }

    /// <summary>
    /// Transaction history item data model, represent one transaction.
    /// </summary>
    public class TransactionHistoryItem
    {
        /// <summary>
        /// Transaction UUID identificator.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Market code.
        /// </summary>
        public string Market { get; set; }

        /// <summary>
        /// The transaction execution time (unix).
        /// </summary>
        public long Time { get; set; }

        /// <summary>
        /// Amount of currency in the transaction.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The transation rate.
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// Who initiated the transaction: buy or sell.
        /// </summary>
        [JsonProperty("initializedBy")]
        public string InitialBy { get; set; }

        /// <summary>
        /// The role user play in executed the transaction: buy or sell.
        /// </summary>
        [JsonProperty("userAction")]
        public string UserActionType { get; set; }

        /// <summary>
        /// Is the user completing a existing offer of another user? Flag (true - taker, false - maker).
        /// </summary>
        [JsonProperty("wasTaker")]
        public bool WasTaker { get; set; }

        /// <summary>
        /// Offer UUID identificator.
        /// </summary>
        [JsonProperty("offerId")]
        public string OfferId { get; set; }
        
        /// <summary>
        /// Value of commission charged.
        /// </summary>
        [JsonProperty("commissionValue")]
        public decimal CommissionValue { get; set; }
    }
}
