using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    /// <summary>
    /// Data model for orderbook response from exchange.
    /// </summary>
    public class Orderbook
    {
        /// <summary>
        /// List of sell transaction
        /// </summary>
        public List<OrderBookItem> Sell { get; set; }

        /// <summary>
        /// List of buy transaction
        /// </summary>
        public List<OrderBookItem> Buy { get; set; }

        /// <summary>
        /// Time (unix) for which returned orderbook, are valid.
        /// </summary>
        public long Timestamp { get; set; }

        /// <summary>
        /// Sequence number, it allows you to keep the order of received data.
        /// </summary>
        public int SeqNo { get; set; }
    }

    /// <summary>
    /// Orderbook item, use for Buy and Sell transaction.
    /// </summary>
    public class OrderBookItem
    {
        /// <summary>
        /// Postion rate.
        /// </summary>
        [JsonProperty("ra")]
        public decimal PositionRate { get; set; }

        /// <summary>
        /// Amount of currency in postion.
        /// </summary>
        [JsonProperty("ca")]
        public decimal Amout { get; set; }

        /// <summary>
        /// Initial amount of currency.
        /// </summary>
        [JsonProperty("sa")]
        public decimal InitialAmount { get; set; }

        /// <summary>
        /// Amount of currency before last change.
        /// </summary>
        [JsonProperty("pa")]
        public decimal AmountBeforeTheLastChange { get; set; }

        /// <summary>
        /// Number of offers in this postion.
        /// </summary>
        [JsonProperty("co")]
        public int NumberOfOfferInPosition { get; set; }
    }
}
