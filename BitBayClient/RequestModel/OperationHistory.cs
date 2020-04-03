using BitBayClient.Converters;
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
        /// List of balance currencies string, use for filted resault. If null, will not send to a server.
        /// </summary>
        [JsonProperty("balanceCurrencies")]
        public List<string> BalanceCurrencies { get; set; } = new List<string>();
        
        /// <summary>
        /// Filter result from time (unix). If null, will not send to a server.
        /// </summary>
        [JsonProperty("fromTime", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long FromTime { get; set; }

        /// <summary>
        /// Filter result to time (unix). If null, will not send to a server.
        /// </summary>
        [JsonProperty("toTime", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long ToTime { get; set; }

        /// <summary>
        /// Limit of result, default 20.
        /// </summary>
        public int Limit { get; set; } = 20;

        /// <summary>
        /// Result offset, default 0;
        /// </summary>
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Filter result from value. If null, will not send to a server.
        /// </summary>
        [JsonProperty("fromValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal FromValue { get; set; }

        /// <summary>
        /// Filter result to value. If null, will not send to a server.
        /// </summary>
        [JsonProperty("toValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal ToValue { get; set; }

        /// <summary>
        /// Type of balance walet: fiat or crypto, convert from BalanceType, used inside
        /// </summary>
        [JsonProperty("balanceTypes")]
        public string BalanceTypesString { get; set; }

        /// <summary>
        /// List of types of operations.
        /// </summary>
        [JsonProperty("types")]
        public List<string> TypesString { get; set; } = new List<string>();

        /// <summary>
        /// Sort result configuration. Default set order by time, DESC.
        /// </summary>
        public Sort Sort { get; set; } = new Sort("time", SortOrderTypes.DESC);

        /// <summary>
        /// Request has next page, default false.
        /// </summary>
        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; } = false;

        /// <summary>
        /// Cursor for get next page, default start.
        /// </summary>
        [JsonProperty("nextPageCursor")]
        public string NextPageCursor { get; set; } = "start";
    }
    
    /// <summary>
    /// Sort configuration data struct.
    /// </summary>
    public class Sort
    {
        /// <summary>
        /// Select field to sort by this field.
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
        public string OrderString { get => Order.ToString(); }

        /// <summary>
        /// Construct sort object.
        /// </summary>
        /// <param name="sortBy">Set operation type to be ordered.</param>
        /// <param name="orderBy">Set order by.</param>
        public Sort(string sortBy, SortOrderTypes orderBy)
        {
            By = sortBy;
            Order = orderBy;
        }
    }
}
