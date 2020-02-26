using BitBayClient.Converters;
using CurrencyPair;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    public class OperationHistory
    {
        [JsonProperty("balancesId")]
        public List<string> BalancesId { get; set; }

        [JsonProperty("balanceCurrencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Currency> BalanceCurrencies { get; set; }

        [JsonIgnore]
        public DateTime FromDate { get; set; }
        [JsonProperty("fromTime", NullValueHandling = NullValueHandling.Ignore)]
        public long FromTime { get => Converters.Date.Convert(FromDate); }

        [JsonIgnore]
        public DateTime ToDate { get; set; }
        [JsonProperty("toTime", NullValueHandling = NullValueHandling.Ignore)]
        public long ToTime { get => Converters.Date.Convert(ToDate); }

        [JsonProperty("fromValue", NullValueHandling = NullValueHandling.Ignore)]
        public decimal FromValue { get; set; }

        [JsonProperty("toValue", NullValueHandling = NullValueHandling.Ignore)]
        public decimal ToValue { get; set; }

        [JsonIgnore]
        public CurrencyType BalancesType { get; set; }
        [JsonProperty("balanceTypes")]
        public string BalanceTypesString { get => BalancesType.ToString(); }

        [JsonIgnore]
        public List<OperationTypes> Types { get; set; }
        [JsonProperty("types")]
        public List<string> TypesString { get => GetOperationTypesStrings(); }

        List<string> GetOperationTypesStrings()
        {
            List<string> output = new List<string>();

            for (int i = 0; i < Types.Count; i++)
                output.Add(Types[i].ToString());

            return output;
        }

        public Sort Sort { get; set; }
    }
    
    public class Sort
    {
        public string By { get; set; }

        public SortOrderTypes Order { get; set; }
    }
}
