using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// Data model for new offer request to exchange.
    /// </summary>
    public class NewOfferRequest
    {
        /// <summary>
        /// Amount of currency in position. REQUIRED
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Offer rate (price). REQUIRED
        /// </summary>
        public float Rate { get; set; }

        /// <summary>
        /// Use only in market offer, replaces rate. Opcjonal
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Type of offer: buy or sell. REQUIRED
        /// </summary>
        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        /// <summary>
        /// Offer mode: limit or market. REQUIRED
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Is the offer post-only? atribute. Opcjonal
        /// </summary>
        [JsonProperty("postOnly")]
        public bool PostOnly { get; set; }

        /// <summary>
        /// Is the offer fill or kill? atribute. Opcjonal
        /// </summary>
        [JsonProperty("fillOrKill")]
        public bool FillOrKill { get; set; }

        /// <summary>
        /// Is the offer immediate or cancel? atribute. Opcjonal
        /// </summary>
        [JsonProperty("immediateOrCancel")]
        public bool ImmediateOrCancel { get; set; }

        /// <summary>
        /// Different UUID wallets for first currency in pair. Opcjonal
        /// </summary>
        [JsonProperty("firstBalanceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstBalanceId { get; set; }

        /// <summary>
        /// Different UUID wallets for second currency in pair. Opcjonal
        /// </summary>
        [JsonProperty("secondBalanceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SecondBalanceId { get; set; }
    }
}
