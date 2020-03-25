using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;
using BitBayClient.Converters;

namespace BitBayClient.RequestModel
{
    public class TransactionHistoryRequest
    {
        public List<string> Markets { get; set; }

        [JsonProperty("nextPageCursor")]
        public string NextPageCursor { get; set; } = "start";

        [JsonProperty("rateFrom")]
        public decimal RateFrom { get; set; }

        [JsonProperty("rateTo")]
        public decimal RateTo { get; set; }

        [JsonProperty("fromTime", NullValueHandling = NullValueHandling.Ignore)]
        public long FromTime { get; set; }

        [JsonProperty("toTime", NullValueHandling = NullValueHandling.Ignore)]
        public long ToTime { get; set; }

        [JsonProperty("userAction", NullValueHandling = NullValueHandling.Ignore)]
        public string UserAction { get; set; }
    }
}
