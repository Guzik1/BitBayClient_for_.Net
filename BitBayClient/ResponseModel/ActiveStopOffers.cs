using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using CurrencyPair;
using ExchangeBasicData;
using BitBayClient.RequestModel;

namespace BitBayClient.ResponseModel
{
    public class ActiveStopOffers
    {
        public ActiveStopOffers() { }

        internal ActiveStopOffers(List<ActiveStopOfferItem> offers)
        {
            Offers = offers;
        }

        public List<ActiveStopOfferItem> Offers { get; set; }
    }

    public class ActiveStopOfferItem {
        public string Id { get; set; }

        public string OperationId { get; set; }

        public string UserId { get; set; }

        public Pair Pair { get; set; }

        public decimal Amount { get; set; }

        public decimal Rate { get; set; }

        public decimal StopRate { get; set; }

        public string Status { get; set; }

        public TransactionType Type { get; set; }

        public OfferType OfferMode { get; set; }

        public Balances Balances { get; set; }

        public DateTime CratedTime { get; set; }

        public List<object> Flags { get; set; }
    }
}
