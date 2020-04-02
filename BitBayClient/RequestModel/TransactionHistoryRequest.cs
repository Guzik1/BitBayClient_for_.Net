using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using BitBayClient.Converters;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// Data model for get transaction history, is parameter in <see cref="History.GetTransactionHistory(TransactionHistoryRequest)"/>, use to filter resault.
    /// </summary>
    public class TransactionHistoryRequest
    {
        /// <summary>
        /// List of markets code. Use for filter.
        /// </summary>
        public List<string> Markets { get; set; } = new List<string>();

        /// <summary>
        /// Next page cursor, use for get next pages of resault. Default cursor is start.
        /// </summary>
        [JsonProperty("nextPageCursor")]
        public string NextPageCursor { get; set; } = "start";

        /// <summary>
        /// Rate from filter.
        /// </summary>
        [JsonProperty("rateFrom")]
        public decimal RateFrom { get; set; }

        /// <summary>
        /// Rate to filter.
        /// </summary>
        [JsonProperty("rateTo")]
        public decimal RateTo { get; set; }

        /// <summary>
        /// From time filter (unix).
        /// </summary>
        [JsonProperty("fromTime", NullValueHandling = NullValueHandling.Ignore)]
        public long FromTime { get; set; }

        /// <summary>
        /// To time filter (unix).
        /// </summary>
        [JsonProperty("toTime", NullValueHandling = NullValueHandling.Ignore)]
        public long ToTime { get; set; }

        /// <summary>
        /// Filter, user action: buy or sell.
        /// </summary>
        [JsonProperty("userAction", NullValueHandling = NullValueHandling.Ignore)]
        public string UserAction { get; set; }
    }
}
