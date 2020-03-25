using BitBayClient.Converters;
using CurrencyPair;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    public class Stats
    {
        [JsonProperty("stats")]
        public Stat Stats24h { get; set; }
    }

    public class AllStats
    {
        [JsonProperty("items")]
        public Dictionary<string, Stat> Stats24h { get; set; }
    }

    public class Stat
    {
        [JsonProperty("m")]
        public string Code { get; set; }

        [JsonProperty("h")]
        public decimal HighestRate { get; set; }

        [JsonProperty("l")]
        public decimal LowestRate { get; set; }

        [JsonProperty("v")]
        public decimal Volume { get; set; }

        [JsonProperty("r24h")]
        public decimal AvarageRate { get; set; }
    }
}
