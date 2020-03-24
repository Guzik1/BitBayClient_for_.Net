using BitBayClient.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;

namespace BitBayClient.ResponseModel
{
    public class Ticker
    {
        public TickerItem TickerItem { get; set; }
    }

    public class AllTickers
    {
        [JsonProperty("items")]
        [JsonConverter(typeof(SingleOrArrayConverter<Dictionary<Currency, TickerItem>>))]
        public Dictionary<string, TickerItem> Tickers { get; set; }
    }

    public class TickerItem
    {
        public Market Market { get; set; }

        public long Time { get; set; }

        public decimal HighestBid { get; set; }

        public decimal LowestAsk { get; set; }

        public decimal Rate { get; set; }

        public decimal PreviousRate { get; set; }
    }

    public class Market
    {
        public string Code { get; set; }

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
