using BitBayClient.Converters;
using CurrencyPair;
using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    internal class ActiveOffersTemp: IResponseConvert<ActiveOffers>
    {
        [JsonProperty("items")]
        [JsonConverter(typeof(SingleOrArrayConverter<ActiveOfferItemTemp>))]
        public List<ActiveOfferItemTemp> ActiveOffer { get; set; }

        public ActiveOffers GetResponse()
        {
            List<ActiveOfferItem> activeOffer = new List<ActiveOfferItem>();

            foreach(ActiveOfferItemTemp activeOfferItem in ActiveOffer)
            {
                ActiveOfferItem aoi = new ActiveOfferItem()
                {
                    Pair = new Pair(activeOfferItem.Market),
                    Type = TransactionTypeExtensions.Parse(activeOfferItem.OfferType),
                    Id = activeOfferItem.Id,
                    CurrentAmount = activeOfferItem.CurrentAmount,
                    LockedAmount = activeOfferItem.LockedAmount,
                    Rate = activeOfferItem.Rate,
                    StartAmount = activeOfferItem.StartAmount,
                    OpenDate = Date.Convert(activeOfferItem.Time),
                    PostOnly = activeOfferItem.PostOnly,
                    OfferMode = OfferTypeExtension.Parse(activeOfferItem.Mode),
                    ReceivedAmount = activeOfferItem.ReceivedAmount,
                    FirstBalanceId = activeOfferItem.FirstBalanceId,
                    SecondBalanceId = activeOfferItem.SecondBalanceId
                };

                activeOffer.Add(aoi);
            }

            return new ActiveOffers(activeOffer);
        }
    }

    internal class ActiveOfferItemTemp
    {
        public string Market { get; set; }

        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        public string Id { get; set; }

        [JsonProperty("currentAmount")]
        public decimal CurrentAmount { get; set; }

        [JsonProperty("lockedAmount")]
        public decimal LockedAmount { get; set; }

        [JsonProperty("rate")]
        public decimal Rate { get; set; }

        [JsonProperty("startAmount")]
        public decimal StartAmount { get; set; }

        public long Time { get; set; }

        [JsonProperty("postOnly")]
        public bool PostOnly { get; set; }

        public string Mode { get; set; }

        [JsonProperty("receivedAmount")]
        public decimal ReceivedAmount { get; set; }

        [JsonProperty("firstBalanceId")]
        public string FirstBalanceId { get; set; }

        [JsonProperty("secondBalanceId")]
        public string SecondBalanceId { get; set; }

    }
}
