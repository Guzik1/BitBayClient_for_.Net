using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Data model of response on new offer request.
    /// </summary>
    public class NewOffer
    {
        /// <summary>
        /// Flag informing if the offerta was immediately implemented in full.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// Offer identificator
        /// </summary>
        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        /// <summary>
        /// List of transaction completed immedietly.
        /// </summary>
        public List<NewOfferTransactionItem> Transactions { get; set; }
    }

    /// <summary>
    /// Data model for transaction realized on add offer, immedietly
    /// </summary>
    public class NewOfferTransactionItem
    {
        /// <summary>
        /// Amount on currency in transaction
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Transaction rate.
        /// </summary>
        public decimal Rate { get; set; }
    }
}
