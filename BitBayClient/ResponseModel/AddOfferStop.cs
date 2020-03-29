using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Data model represent response on <see cref="PrivateTrading.AddNewOffer(string, RequestModel.NewOfferRequest)"/> request.
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
