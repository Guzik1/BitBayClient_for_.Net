using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;
using BitBayClient.Converters;

namespace BitBayClient.ResponseModel
{
    public class WalletListResponse
    {
        public List<Walet> Balances { get; set; }
    }

    public class Walet
    {
        public string Id { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("availableFunds")]
        public decimal AvailableFunds { get; set; }

        [JsonProperty("totalFunds")]
        public decimal TotalFunds { get; set; }

        [JsonProperty("lockedFunds")]
        public decimal LockedFunds { get; set; }

        [JsonIgnore]
        public Currency Currency { get; set; }
        [JsonProperty("currency")]
        public string CurrencyString { set { Currency = CurrencyExtension.Parse(value); } }

        [JsonIgnore]
        public CurrencyType Type { get; set; }
        [JsonProperty("type")]
        public string TypeString { set { Type = CurrencyTypeExtension.Parse(value); } }

        public string Name { get; set; }

        [JsonIgnore]
        public ApplicationList BalanceEngine { get; set; }
        [JsonProperty("balanceEngine")]
        public string BalanceEngineString { set { BalanceEngine = EnumConverter.Parse<ApplicationList>(value); } }
    }
}
