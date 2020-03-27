using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ExchangeBasicData;
using BitBayClient.RequestModel.Temp;

namespace BitBayClient.RequestModel.OLD
{
    internal class NewOfferRequest
    {
        public float Amount { get; set; }

        public float Rate { get; set; }

        public float Price { get; set; }

        public TransactionType Type { get; set; }

        public OfferType OfferMode { get; set; }

        public bool PostOnly { get; set; }

        public bool FillOrKill { get; set; }

        public bool ImmediateOrCancel { get; set; }

        public string FirstBalanceId { get; set; }

        public string SecondBalanceId { get; set; }
    }
}
