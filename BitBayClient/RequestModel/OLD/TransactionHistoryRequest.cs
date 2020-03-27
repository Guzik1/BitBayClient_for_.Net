using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;
using ExchangeBasicData;

namespace BitBayClient.RequestModel.OLD
{
    internal class TransactionHistoryRequest
    {
        public List<Pair> Pair { get; set; } = new List<Pair>();

        public string NextPageCursor { get; set; } = "start";

        public decimal RateFrom { get; set; }

        public decimal RateTo { get; set; }

        public DateTime FromTime { get; set; }

        public DateTime ToTime { get; set; }

        public TransactionType UserAction { get; set; }

        internal List<string> GetMarkets()
        {
            List<string> list = new List<string>();

            for (int i = 0; i < Pair.Count; i++)
                list.Add(Pair[i].ToStringWithDash());

            return list;
        }
    }
}
