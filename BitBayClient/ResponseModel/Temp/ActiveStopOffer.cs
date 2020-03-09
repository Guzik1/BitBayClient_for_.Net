using BitBayClient.Converters;
using BitBayClient.RequestModel;
using CurrencyPair;
using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    internal class ActiveStopOffersTemp: IResponseConvert<ActiveStopOffers>
    {
        [JsonProperty("items")]
        [JsonConverter(typeof(SingleOrArrayConverter<ActiveStopOfferItemTemp>))]
        public List<ActiveStopOfferItemTemp> ActiveOffer { get; set; }

        public ActiveStopOffers GetResponse()
        {
            List<ActiveStopOfferItem> activeOffer = new List<ActiveStopOfferItem>();

            foreach(ActiveStopOfferItemTemp activeOfferItem in ActiveOffer)
            {
                ActiveStopOfferItem aoi = new ActiveStopOfferItem()
                {
                    Id = activeOfferItem.Id,
                    OperationId = activeOfferItem.OperationId,
                    UserId = activeOfferItem.UserId,
                    Pair = new Pair(activeOfferItem.Market),
                    Amount = activeOfferItem.Amount,
                    Rate = activeOfferItem.Rate,
                    StopRate = activeOfferItem.StopRate,
                    Status = activeOfferItem.Status,
                    Type = TransactionTypeExtensions.Parse(activeOfferItem.OfferType),
                    OfferMode = OfferTypeExtension.Parse(activeOfferItem.Mode),
                    Balances = activeOfferItem.Balances,
                    CratedTime = Date.Convert(activeOfferItem.Time),
                    Flags = activeOfferItem.Flags
                };

                activeOffer.Add(aoi);
            }

            return new ActiveStopOffers(activeOffer);
        }
    }

    internal class ActiveStopOfferItemTemp
    {
        public string Id { get; set; }

        [JsonProperty("operationId")]
        public string OperationId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        public string Market { get; set; }

        public decimal Amount { get; set; }

        public decimal Rate { get; set; }

        [JsonProperty("stopRate")]
        public decimal StopRate { get; set; }

        public string Status { get; set; }

        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        public string Mode { get; set; }

        public Balances Balances { get; set; }

        [JsonProperty("createdAt")]
        public long Time { get; set; }

        public List<object> Flags { get; set; }

    }
}
