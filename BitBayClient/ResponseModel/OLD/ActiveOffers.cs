using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using BitBayClient.Converters;
using CurrencyPair;
using ExchangeBasicData;

namespace BitBayClient.ResponseModel.OLD
{ 
    internal class ActiveOffersOLD
    {
        public List<ActiveOfferItem> ActiveOffer { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ActiveOffersOLD() { }

        internal ActiveOffersOLD(List<ActiveOfferItem> activeOffers)
        {
            ActiveOffer = activeOffers;
        }
    }

    internal class ActiveOfferItem
    {
        public Pair Pair { get; set; }

        public TransactionType Type { get; set; }

        public string Id { get; set; }

        public decimal CurrentAmount { get; set; }

        public decimal LockedAmount { get; set; }
        
        public decimal Rate { get; set; }

        public decimal StartAmount { get; set; }

        public DateTime OpenDate { get; set; }

        public bool PostOnly { get; set; }

        public OfferType OfferMode { get; set; }

        public decimal ReceivedAmount { get; set; }

        public string FirstBalanceId { get; set; }

        public string SecondBalanceId { get; set; }
    }
}
