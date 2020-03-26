using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// Data model for new stop offer request (<see cref="BitBayClient.AddNewStopOffer(CurrencyPair.Pair, NewStopOfferRequest)"/>) to exchange.
    /// </summary>
    public class NewStopOfferRequest
    {
        /// <summary>
        /// Offer type: buy or sell. REQUIRED
        /// </summary>
        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        /// <summary>
        /// Currency amount. REQUIRED
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Last transaction rate, when this offer was activate. REQUIRED
        /// </summary>
        [JsonProperty("stopRate")]
        public float StopRate { get; set; }

        /// <summary>
        /// Offer mode: stop-limit or stop-market. REQUIRED
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Offer rate (price). Required in stop-limit mode and not required in stop-market mode.
        /// </summary>
        public float Rate { get; set; }

        /// <summary>
        /// Using balances for this offer. When null, use default balances. Optional
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Balances Balances { get; set; }

        /// <summary>
        /// Ignore invalid stop rate. Prepare for add new offer that can be implemented immedietly.
        /// </summary>
        [JsonProperty("ignoreInvalidStopRate")]
        public bool IgnoreInvalidStopRate { get; set; }
    }
}
