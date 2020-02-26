using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;

namespace BitBayClient.RequestModel
{
    public class TransactionHistory
    {
        [JsonIgnore]
        public List<Pair> Pair { get; set; } = new List<Pair>();

        public List<string> Markets => GetMarkets();

        [JsonProperty("nextPageCursor")]
        public string NextPageCursor { get; set; } = "start";

        [JsonProperty("rateFrom")]
        public decimal RateFrom { get; set; }

        [JsonProperty("rateTo")]
        public decimal RateTo { get; set; }

        List<string> GetMarkets()
        {
            List<string> list = new List<string>();

            for (int i = 0; i < Pair.Count; i++)
                list.Add(Pair[i].ToStringWithDash());

            return list;
        }
    }
}
