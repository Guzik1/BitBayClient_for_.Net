using BitBayClient.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    public class CandlesData
    {
        public Dictionary<long, CandleItem> Items { get; set; }
    }

    public class CandleItem
    {
        [JsonProperty("o")]
        public decimal OpenRate { get; set; }

        [JsonProperty("c")]
        public decimal CloseRate { get; set; }

        [JsonProperty("h")]
        public decimal HighestRate { get; set; }

        [JsonProperty("l")]
        public decimal LowestRate { get; set; }

        [JsonProperty("v")]
        public decimal Volume { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append("OpenRate: " + OpenRate);
            output.Append(", CloseRate: " + CloseRate);
            output.Append(", HighestRate: " + HighestRate);
            output.Append(", LowestRate: " + LowestRate);
            output.Append(", Valume: " + Volume);

            return output.ToString();
        }
    }
}