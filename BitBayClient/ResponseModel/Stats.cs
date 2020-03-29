using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Stat for one currency pair on exchange.
    /// </summary>
    public class StatsOne
    {
        /// <summary>
        /// 24 hours pair stats.
        /// </summary>
        [JsonProperty("stats")]
        public Stats Stats24h { get; set; }
    }

    /// <summary>
    /// Stats for all currency pair on exchange.
    /// </summary>
    public class AllStats
    {
        /// <summary>
        /// 24 hours pair stats. Key is currency pair code, Value is stats for (Key) pair.
        /// </summary>
        [JsonProperty("items")]
        public Dictionary<string, Stats> Stats24h { get; set; }
    }

    /// <summary>
    /// Data model for details of 24 hours pair stats.
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// Currency pair code.
        /// </summary>
        [JsonProperty("m")]
        public string Code { get; set; }

        /// <summary>
        /// Highest price rate.
        /// </summary>
        [JsonProperty("h")]
        public decimal HighestRate { get; set; }

        /// <summary>
        /// Lowest price rate.
        /// </summary>
        [JsonProperty("l")]
        public decimal LowestRate { get; set; }

        /// <summary>
        /// Volume in pair.
        /// </summary>
        [JsonProperty("v")]
        public decimal Volume { get; set; }

        /// <summary>
        /// Avarage 24h rate in pair.
        /// </summary>
        [JsonProperty("r24h")]
        public decimal AvarageRate { get; set; }
    }
}
