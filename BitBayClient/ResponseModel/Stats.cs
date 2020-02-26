using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using BitBayClient.Converters;
using CurrencyPair;

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
        [JsonConverter(typeof(SingleOrArrayConverter<Dictionary<string, Stat>>))]
        public List<Dictionary<string, Stat>> Stats24h { get; set; }
    }

    public class Stat
    {
        [JsonProperty("m")]
        public string Code { set { Pair = new Pair(value); } }

        public Pair Pair { get; set; }

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
