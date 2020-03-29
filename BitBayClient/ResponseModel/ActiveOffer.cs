using BitBayClient.Converters;
using CurrencyPair;
using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Data model for active offers response on <see cref="PrivateTrading.GetActiveOffer(string)" /> request.
    /// </summary>
    public class ActiveOffers
    {
        /// <summary>
        /// List of active your offers.
        /// </summary>
        [JsonProperty("items")]
        [JsonConverter(typeof(SingleOrArrayConverter<ActiveOffer>))]
        public List<ActiveOffer> ActiveOffer { get; set; }
    }

    /// <summary>
    /// Data model represent one active offer.
    /// </summary>
    public class ActiveOffer
    {
        /// <summary>
        /// Code market, currency pair.
        /// </summary>
        public string Market { get; set; }

        /// <summary>
        /// Type of offer: buy or sell.
        /// </summary>
        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        /// <summary>
        /// Offer UUID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Currency amount in position.
        /// </summary>
        [JsonProperty("currentAmount")]
        public decimal CurrentAmount { get; set; }

        /// <summary>
        /// Locked amount on exchange account.
        /// </summary>
        [JsonProperty("lockedAmount")]
        public decimal LockedAmount { get; set; }

        /// <summary>
        /// Offer rate (price).
        /// </summary>
        [JsonProperty("rate")]
        public decimal Rate { get; set; }

        /// <summary>
        /// Offer initial amount of currence.
        /// </summary>
        [JsonProperty("startAmount")]
        public decimal StartAmount { get; set; }

        /// <summary>
        /// Initial offer time (unix).
        /// </summary>
        public long Time { get; set; }

        /// <summary>
        /// Is the offer post-only.
        /// </summary>
        [JsonProperty("postOnly")]
        public bool PostOnly { get; set; }

        /// <summary>
        /// Type of offer: limit or market.
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Amount of currency, recived from this offer.
        /// </summary>
        [JsonProperty("receivedAmount")]
        public decimal ReceivedAmount { get; set; }

        /// <summary>
        /// First balance UUID.
        /// </summary>
        [JsonProperty("firstBalanceId")]
        public string FirstBalanceId { get; set; }

        /// <summary>
        /// Second balance UUID.
        /// </summary>
        [JsonProperty("secondBalanceId")]
        public string SecondBalanceId { get; set; }

    }
}
