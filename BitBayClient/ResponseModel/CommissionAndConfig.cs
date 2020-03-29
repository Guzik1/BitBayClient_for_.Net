using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Data model for response on <see cref="PrivateTrading.GetCommissionsAndConfiguration(string)"/> request.
    /// </summary>
    public class CommissionAndConfigPre
    {
        /// <summary>
        /// Confiuguration and commission data.
        /// </summary>
        public CommissionAndConfig Config { get; set; }
    }

    /// <summary>
    /// Data model for Commision and configuration details.
    /// </summary>
    public class CommissionAndConfig
    {
        /// <summary>
        /// Buy configuration.
        /// </summary>
        public BuySellConfigItem Buy { get; set; }

        /// <summary>
        /// Sell configuration.
        /// </summary>
        public BuySellConfigItem Sell { get; set; }

        /// <summary>
        /// Configuration for first currence in pair.
        /// </summary>
        public MinimalTransaction First { get; set; }

        /// <summary>
        /// Configuration for second currence in pair.
        /// </summary>
        public MinimalTransaction Second { get; set; }
    }

    /// <summary>
    /// Data model for buy or sell configuration item.
    /// </summary>
    public class BuySellConfigItem
    {
        /// <summary>
        /// Commissions levels.
        /// </summary>
        public Commissions Commissions { get; set; }
    }

    /// <summary>
    /// Commision data model for config buy and sell item.
    /// </summary>
    public class Commissions
    {
        /// <summary>
        /// Actual maker commision.
        /// </summary>
        public decimal Maker { get; set; }

        /// <summary>
        /// Actual taker commision.
        /// </summary>
        public decimal Taker { get; set; }
    }

    /// <summary>
    /// Minimal transaction data model.
    /// </summary>
    public class MinimalTransaction
    {
        /// <summary>
        /// Default balance UUID.
        /// </summary>
        public string BalanceId { get; set; }

        /// <summary>
        /// Minimal transaction value.
        /// </summary>
        [JsonProperty("minValue")]
        public decimal MinValue { get; set; }
    }
}
