using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Data model represent response on <see cref="BitBayClient.AddNewOffer(CurrencyPair.Pair, RequestModel.NewOfferRequest)"/> request.
    /// </summary>
    public class AddOfferStop
    {
        /// <summary>
        /// Stop offer UUID identificator.
        /// </summary>
        [JsonProperty("stopOfferId")]
        public string StopOfferId { get; set; }
    }
}
