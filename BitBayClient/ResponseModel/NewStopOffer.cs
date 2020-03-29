using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Data model stop offer response, return on <see cref="PrivateStopTrading.AddNewStopOffer(string, RequestModel.NewStopOfferRequest)"/> response.
    /// </summary>
    public class NewStopOffer
    {
        /// <summary>
        /// Stop offer UUID identificator.
        /// </summary>
        [JsonProperty("stopOfferId")]
        public string StopOfferId { get; set; }
    }
}
