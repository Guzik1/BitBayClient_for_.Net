﻿using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel.Temp
{
    internal class NewOfferRequestTemp: IRequestConverter<NewOfferRequest>
    {
        public float Amount { get; set; }

        public float Rate { get; set; }

        public float Price { get; set; }

        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        public string Mode { get; set; }

        [JsonProperty("postOnly")]
        public bool PostOnly { get; set; }

        [JsonProperty("fillOrKill")]
        public bool FillOrKill { get; set; }

        [JsonProperty("immediateOrCancel")]
        public bool ImmediateOrCancel { get; set; }

        [JsonProperty("firstBalanceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstBalanceId { get; set; }

        [JsonProperty("secondBalanceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SecondBalanceId { get; set; }

        public void SetRequest(NewOfferRequest fromObject)
        {
            Amount = fromObject.Amount;
            Rate = fromObject.Rate;
            Price = fromObject.Price;
            OfferType = fromObject.Type.ToLowerString();
            Mode = fromObject.OfferMode.ToLowerString();
            PostOnly = fromObject.PostOnly;
            ImmediateOrCancel = fromObject.ImmediateOrCancel;
        }
    }
}