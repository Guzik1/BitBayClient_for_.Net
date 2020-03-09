using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    public class NewOffer
    {
        public bool Completed { get; set; }

        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        public List<NewOfferTransactionData> Transactions { get; set; }
    }

    public class NewOfferTransactionData
    {
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
    }
}
