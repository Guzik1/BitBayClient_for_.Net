using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ExchangeBasicData;

namespace BitBayClient.RequestModel.OLD
{
    internal class NewStopOfferRequest
    {
        public TransactionType Type { get; set; }

        public float Amount { get; set; }

        public float StopRate { get; set; }

        public float Rate { get; set; }

        public Balances Balances { get; set; }

        public bool IgnoreInvalidStopRate { get; set; }
    }
}
