using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using BitBayClient.Converters;
using CurrencyPair;

namespace BitBayClient.ResponseModel
{
    public class Tickers
    {
        public TickerItem Ticker { get; set; }
    }

    public class AllTickers
    {
        public Dictionary<Pair, TickerItem> Tickers { get; set; }
    }

    public class TickerItem
    {
        public Market Market { get; set; }

        public DateTime Time { get; set; }

        public decimal HighestBid { get; set; }

        public decimal LowestAsk { get; set; }

        public decimal Rate { get; set; }

        public decimal PreviousRate { get; set; }
    }

    public class Market
    {
        public Pair Pair {get; set;}

        public Details First { get; set; }

        public Details Second { get; set; }
    }

    public class Details
    {
        public string Currency { get; set; }

        public decimal MinOffer { get; set; }

        public int Scale { get; set; }
    }
}
