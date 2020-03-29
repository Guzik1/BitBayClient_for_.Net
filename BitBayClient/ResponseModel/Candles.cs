using BitBayClient.Converters;
using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Data model for get candles request.
    /// </summary>
    public class Candles
    {
        /// <summary>
        /// List of candles item, key is open candle time (unix), value is candle item.
        /// </summary>
        [JsonProperty("items")]
        public Dictionary<long, CandleItem> CandlesList { get; set; }

        /// <summary>
        /// Resolution of candles in candle list
        /// </summary>
        [JsonIgnore]
        public CandleResolution Resoluton { get; internal set; }
    }

    /// <summary>
    /// Candle one item details.
    /// </summary>
    public class CandleItem
    {
        /// <summary>
        /// Candle open rate.
        /// </summary>
        [JsonProperty("o")]
        public decimal OpenRate { get; set; }

        /// <summary>
        /// Candle close rate.
        /// </summary>
        [JsonProperty("c")]
        public decimal CloseRate { get; set; }

        /// <summary>
        /// Highest rate in candle.
        /// </summary>
        [JsonProperty("h")]
        public decimal HighestRate { get; set; }

        /// <summary>
        /// Lowest rate in candle.
        /// </summary>
        [JsonProperty("l")]
        public decimal LowestRate { get; set; }

        /// <summary>
        /// Volume in candle.
        /// </summary>
        [JsonProperty("v")]
        public decimal Volume { get; set; }

        /// <summary>
        /// Convert this object to string.
        /// </summary>
        /// <returns>String of this object.</returns>
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append("OpenRate: " + OpenRate);
            output.Append(", CloseRate: " + CloseRate);
            output.Append(", HighestRate: " + HighestRate);
            output.Append(", LowestRate: " + LowestRate);
            output.Append(", Valume: " + Volume);

            return output.ToString();
        }
    }
}