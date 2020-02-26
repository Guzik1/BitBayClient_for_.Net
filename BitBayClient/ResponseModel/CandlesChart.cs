using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using RestApiClient;
using BitBayClient.Converters;

namespace BitBayClient.ResponseModel
{
    public class CandlesChart
    {
        [JsonProperty("items")]
        public Dictionary<DateTime, CandleItem> Candles { get; set; }
    }

    internal class CandesChartDeserialize : IResponseDeserializer<CandlesChart>
    {
        public CandlesChart Deserialize(string input)
        {
            CandlesChart output = new CandlesChart();

            PreCandleChartData data = Converters.Deserialize.FromJson<PreCandleChartData>(input);

            output.Candles = new Dictionary<DateTime, CandleItem>();

            for (int i = 0; i < data.Items.Count; i++)
            {
                long id = Int64.Parse((string)data.Items[i][0]);
                DateTime dt = Date.Convert(id);

                CandleItem candle = Converters.Deserialize.FromJson<CandleItem>(data.Items[i][1].ToString());

                output.Candles.Add(dt, candle);
            }

            return output;
        }
    }

    class PreCandleChartData
    {
        public List<List<object>> Items { get; set; }
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
