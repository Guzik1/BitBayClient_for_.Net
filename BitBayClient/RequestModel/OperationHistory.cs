using BitBayClient.Converters;
using CurrencyPair;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// Data model for get operation history, is parameter in <see cref="History.GetOperationHistory(OperationHistoryRequest)"/>, use to filter resault. All fields is optional, use for sort result.
    /// </summary>
    public class OperationHistoryRequest
    {
        /// <summary>
        /// List of balances UUID identificator.
        /// </summary>
        [JsonProperty("balancesId")]
        public List<string> BalancesId { get; set; } = new List<string>();

        /// <summary>
        /// List of balance currencies, use for filted resault. If null, will not send to a server.
        /// </summary>
        [JsonProperty("balanceCurrencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Currency> BalanceCurrencies { get; set; }

        /// <summary>
        /// Filter result from time (unix). If null, will not send to a server.
        /// </summary>
        [JsonProperty("fromTime", NullValueHandling = NullValueHandling.Ignore)]
        public long FromTime { get; set; }

        /// <summary>
        /// Filter result to time (unix). If null, will not send to a server.
        /// </summary>
        [JsonProperty("toTime", NullValueHandling = NullValueHandling.Ignore)]
        public long ToTime { get; set; }

        /// <summary>
        /// Filter result from value. If null, will not send to a server.
        /// </summary>
        [JsonProperty("fromValue", NullValueHandling = NullValueHandling.Ignore)]
        public decimal FromValue { get; set; }

        /// <summary>
        /// Filter result to value. If null, will not send to a server.
        /// </summary>
        [JsonProperty("toValue", NullValueHandling = NullValueHandling.Ignore)]
        public decimal ToValue { get; set; }

        /// <summary>
        /// Type of balance walet: fiat or crypto
        /// </summary>
        [JsonIgnore]
        public WalletType BalanceType { get; set; }

        /// <summary>
        /// Type of balance walet: fiat or crypto, convert from BalanceType, used inside
        /// </summary>
        [JsonProperty("balanceTypes")]
        public string BalanceTypesString { get => BalanceType.ToString(); }

        /// <summary>
        /// List of types of operations.
        /// </summary>
        [JsonProperty("types")]
        public List<string> TypesString { get; set; }

        /// <summary>
        /// Sort result configuration.
        /// </summary>
        public Sort Sort { get; set; }
    }
    
    /// <summary>
    /// Sort configuration data struct.
    /// </summary>
    public class Sort
    {
        /// <summary>
        /// Select field to sort by this field. Example: time.
        /// </summary>
        public string By { get; set; }

        /// <summary>
        /// Sort after ASC or DESC, select from SortOrderTypes enum.
        /// </summary>
        [JsonIgnore]
        public SortOrderTypes Order { get; set; }

        /// <summary>
        /// String order, converted from Order field.
        /// </summary>
        [JsonProperty("order")]
        public string OrderString { get => Order.ToString();  }

        /// <summary>
        /// Construct sort object.
        /// </summary>
        /// <param name="sortBy">Set operation type.</param>
        /// <param name="orderBy">Set order by.</param>
        public Sort(string sortBy, SortOrderTypes orderBy)
        {
            By = sortBy;
            Order = orderBy;
        }
    }
}
