using BitBayClient.Converters;
using CurrencyPair;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    internal class StatsTemp : IResponseConvert<Stats>
    {
        [JsonProperty("stats")]
        public StatTemp Stats24h { get; set; }

        public Stats GetResponse()
        {
            Pair pair = new Pair(Stats24h.Code);
            Stat stat = new Stat(Stats24h.HighestRate, Stats24h.LowestRate, Stats24h.Volume, Stats24h.AvarageRate);

            return new Stats(pair, stat);
        }
    }

    internal class AllStatsTemp : IResponseConvert<AllStats>
    {
        [JsonProperty("items")]
        public Dictionary<string, StatTemp> Stats24h { get; set; }

        public AllStats GetResponse()
        {
            Dictionary<Pair, Stat> stats = new Dictionary<Pair, Stat>();

            foreach(KeyValuePair<string, StatTemp> stat in Stats24h)
            {
                Pair pair = new Pair(stat.Key);
                Stat statNew = new Stat(stat.Value.HighestRate, stat.Value.LowestRate, stat.Value.Volume, stat.Value.AvarageRate);

                stats.Add(pair, statNew);
            }

            return new AllStats(stats);
        }
    }

    internal class StatTemp
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
