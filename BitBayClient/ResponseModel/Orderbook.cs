﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    public class Orderbook
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Orderbook() { }

        internal Orderbook(List<OrderBookItem> sell, List<OrderBookItem> buy, DateTime date, int seqNo)
        {
            Sell = sell;
            Buy = buy;
            Date = date;
            SeqNo = seqNo;
        }

        public List<OrderBookItem> Sell { get; set; }

        public List<OrderBookItem> Buy { get; set; }

        public DateTime Date { get; set; }

        public int SeqNo { get; set; }
    }
     
    public class OrderBookItem
    {
        [JsonProperty("ra")]
        public decimal PositionRate { get; set; }

        [JsonProperty("ca")]
        public decimal Amout { get; set; }

        [JsonProperty("sa")]
        public decimal InitialAmount { get; set; }

        [JsonProperty("pa")]
        public decimal AmountBeforeTheLastChange { get; set; }

        [JsonProperty("co")]
        public int NumberOfOfferInPosition { get; set; }
    }
}
