using BitBayClient.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    internal class OrderbookTemp : IResponseConvert<Orderbook>
    {
        public List<OrderBookItem> Sell { get; set; }

        public List<OrderBookItem> Buy { get; set; }

        public long Timestamp { get; set; }

        public int SeqNo { get; set; }

        public Orderbook GetResponse()
        {
            return new Orderbook(
                Sell,
                Buy,
                Date.Convert(Timestamp),
                SeqNo    
            );
        }
    }
}
