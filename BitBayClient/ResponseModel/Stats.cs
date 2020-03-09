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
        public Stats() { }

        public Stats(Pair pair, Stat stats24h)
        {
            Pair = pair;
            Stats24h = stats24h;
        }

        public Pair Pair { get; set; }

        public Stat Stats24h { get; set; }
    }

    public class AllStats
    {
        public AllStats() { }

        internal AllStats(Dictionary<Pair, Stat> stats24h)
        {
            Stats24h = stats24h;
        }

        public Dictionary<Pair, Stat> Stats24h { get; set; }
    }

    public class Stat
    {
        public Stat() { }

        internal Stat(decimal highestRate, decimal lowestRate, decimal volume, decimal avarageRate)
        {
            HighestRate = highestRate;
            LowestRate = lowestRate;
            Volume = volume;
            AvarageRate = avarageRate;
        }

        public decimal HighestRate { get; set; }

        public decimal LowestRate { get; set; }

        public decimal Volume { get; set; }

        public decimal AvarageRate { get; set; }
    }
}
