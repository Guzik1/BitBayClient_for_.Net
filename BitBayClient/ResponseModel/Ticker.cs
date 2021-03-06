﻿using BitBayClient.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    
    /// <summary>
    /// Data model for one ticker on exchange.
    /// </summary>
    internal class OneTicker
    {
        /// <summary>
        /// Ticker data.
        /// </summary>
        public Ticker Ticker { get; set; }
    }

    /// <summary>
    /// Data model for all tickers on exchange.
    /// </summary>
    internal class Tickers
    {
        /// <summary>
        /// List of tickers, key is market code, value is ticker item.
        /// </summary>
        [JsonProperty("items")]
        public Dictionary<string, Ticker> TickersList { get; set; }
    }

    /// <summary>
    /// Data model represent one ticker.
    /// </summary>
    public class Ticker
    {
        /// <summary>
        /// Details of currency pair. 
        /// </summary>
        public Market Market { get; set; }

        /// <summary>
        /// Data update time (Unix).
        /// </summary>
        public long Time { get; set; }

        /// <summary>
        /// The best rate for buy offer.
        /// </summary>
        [JsonProperty("highestBid")]
        public decimal HighestBid { get; set; }

        /// <summary>
        /// The best rate for sell offer.
        /// </summary>
        [JsonProperty("lowestAsk")]
        public decimal LowestAsk { get; set; }

        /// <summary>
        /// Last transaction rate.
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// Penultimate transaction rate.
        /// </summary>
        [JsonProperty("previousRate")]
        public decimal PreviousRate { get; set; }
    }

    /// <summary>
    /// Data model for Market details info.
    /// </summary>
    public class Market
    {
        /// <summary>
        /// Market code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Details for first currency in Code (currency pair).
        /// </summary>
        public Details First { get; set; }

        /// <summary>
        /// Details for second currency in Code (currency pair).
        /// </summary>
        public Details Second { get; set; }
    }

    /// <summary>
    /// Data model for details of currency setings on exchange.
    /// </summary>
    public class Details
    {
        /// <summary>
        /// Currency code.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Minimal offer value to add new offer. 
        /// </summary>
        public decimal MinOffer { get; set; }

        /// <summary>
        /// The number of places, supported this currency.
        /// </summary>
        public int Scale { get; set; }
    }
}
