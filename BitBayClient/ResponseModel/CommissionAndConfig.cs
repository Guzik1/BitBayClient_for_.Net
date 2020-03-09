using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    public class CommissionAndConfig
    {
        public ConfigItem Config { get; set; }
    }

    public class ConfigItem
    {
        public BuySellItem Buy { get; set; }

        public BuySellItem Sell { get; set; }

        public MinimalTransaction First { get; set; }

        public MinimalTransaction Second { get; set; }
    }

    public class BuySellItem
    {
        public Commissions Commissions { get; set; }
    }

    public class Commissions
    {
        public decimal Maker { get; set; }

        public decimal Taker { get; set; }
    }

    public class MinimalTransaction
    {
        public string BalanceId { get; set; }

        [JsonProperty("minValue")]
        public decimal MinValue { get; set; }
    }
}
