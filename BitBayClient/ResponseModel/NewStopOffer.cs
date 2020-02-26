using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    public class NewStopOffer
    {
        [JsonProperty("stopOfferId")]
        public string StopOfferId { get; set; }
    }
}
