using BitBayClient.Converters;
using BitBayClient.RequestModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Data model represent response on <see cref="PrivateStopTrading.GetActiveStopOffer()" /> request.
    /// </summary>
    public class ActiveStopOffers
    {
        /// <summary>
        /// List of stop offers.
        /// </summary>
        [JsonProperty("items")]
        [JsonConverter(typeof(SingleOrArrayConverter<ActiveStopOfferItem>))]
        public List<ActiveStopOfferItem> ActiveOffer { get; set; }
    }

    /// <summary>
    /// Data model represent one active stop offer.
    /// </summary>
    public class ActiveStopOfferItem
    {
        /// <summary>
        /// UUID offer identificator.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// UUID executed operation identyficator.
        /// </summary>
        [JsonProperty("operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// UUID user identificator, yours number.
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Market code.
        /// </summary>
        public string Market { get; set; }

        /// <summary>
        /// Amount currency in position.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Postion rate (price).
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// Offer activation rate.
        /// </summary>
        [JsonProperty("stopRate")]
        public decimal StopRate { get; set; }

        /// <summary>
        /// Offer status: (available only) active.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Type of offer, available: buy and sell.
        /// </summary>
        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        /// <summary>
        /// Offer mode, abailable: stop-limit and stop-market
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Balances usage to this offer, for two currencies.
        /// </summary>
        public Balances Balances { get; set; }

        /// <summary>
        /// Created time (unix).
        /// </summary>
        [JsonProperty("createdAt")]
        public long Time { get; set; }

        /// <summary>
        /// Flags, already no used.
        /// </summary>
        public List<object> Flags { get; set; }
    }
}