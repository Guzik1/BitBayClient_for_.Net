using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    public class Orderbook
    {
        public List<OrderBookItem> Sell { get; set; }

        public List<OrderBookItem> Buy { get; set; }

        [JsonIgnore]
        public DateTime Date { get; set; }

        public long Timestamp { set { Date = Converters.Date.Convert(value); } }

        public int SeqNo { get; set; }
    }

    public class OrderBookItem
    {
        [JsonProperty("ra")]
        public decimal PositionRate { get; set; }

        [JsonProperty("ca")]
        public decimal AmoutInPosition { get; set; }

        [JsonProperty("sa")]
        public decimal InitialAmountInPosition { get; set; }

        [JsonProperty("pa")]
        public decimal AmountBeforeTheLastChange { get; set; }

        [JsonProperty("co")]
        public int NumberOfOfferInPosition { get; set; }
    }
}
