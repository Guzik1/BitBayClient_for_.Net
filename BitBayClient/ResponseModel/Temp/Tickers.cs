using BitBayClient.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;

namespace BitBayClient.ResponseModel.Temp
{
    internal class TickersTemp: IResponseConvert<Tickers>
    {
        public TickerItemTemp Ticker { get; set; }

        public Tickers GetResponse()
        {
            Market market = new Market() { 
                Pair = new Pair(Ticker.Market.Code), 
                First = Ticker.Market.First, 
                Second = Ticker.Market.Second 
            };

            TickerItem ti = new TickerItem()
            {
                Market = market,
                Time = Date.Convert(Ticker.Time),
                HighestBid = Ticker.HighestBid,
                LowestAsk = Ticker.LowestAsk,
                PreviousRate = Ticker.PreviousRate,
                Rate = Ticker.Rate
            };

            Tickers ticker = new Tickers() { Ticker = ti };

            return ticker;
        }
    }

    internal class AllTickersTemp : IResponseConvert<AllTickers>
    {
        [JsonProperty("items")]
        [JsonConverter(typeof(SingleOrArrayConverter<Dictionary<Currency, TickerItemTemp>>))]
        public Dictionary<string, TickerItemTemp> Tickers { get; set; }

        public AllTickers GetResponse()
        {
            Dictionary<Pair, TickerItem> tickers = new Dictionary<Pair, TickerItem>();

            foreach(KeyValuePair<string, TickerItemTemp> ticker in Tickers)
            {
                Market market = new Market()
                {
                    Pair = new Pair(ticker.Value.Market.Code),
                    First = ticker.Value.Market.First,
                    Second = ticker.Value.Market.Second
                };

                TickerItem ti = new TickerItem()
                {
                    Market = market,
                    Time = Date.Convert(ticker.Value.Time),
                    HighestBid = ticker.Value.HighestBid,
                    LowestAsk = ticker.Value.LowestAsk,
                    PreviousRate = ticker.Value.PreviousRate,
                    Rate = ticker.Value.Rate
                };

                tickers.Add(market.Pair, ti);
            }

            return new AllTickers() { Tickers = tickers };
        }
    }

    internal class TickerItemTemp
    {
        public MarketTemp Market { get; set; }

        public long Time { get; set; }

        public decimal HighestBid { get; set; }

        public decimal LowestAsk { get; set; }

        public decimal Rate { get; set; }

        public decimal PreviousRate { get; set; }
    }

    internal class MarketTemp
    {
        public string Code { get; set; }

        public Details First { get; set; }

        public Details Second { get; set; }
    }
}
