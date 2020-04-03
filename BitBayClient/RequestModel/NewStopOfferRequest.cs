using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// Data model for new stop offer request (<see cref="PrivateStopTrading.AddNewStopOffer(string, NewStopOfferRequest)"/>) to exchange.
    /// </summary>
    public class NewStopOfferRequest
    {
        /// <summary>
        /// Offer type: buy or sell. REQUIRED
        /// </summary>
        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        /// <summary>
        /// Currency amount. REQUIRED
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Last transaction rate, when this offer was activate. REQUIRED
        /// </summary>
        [JsonProperty("stopRate")]
        public decimal StopRate { get; set; }

        /// <summary>
        /// Offer mode: stop-limit or stop-market. REQUIRED
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Offer rate (price). Required in stop-limit mode and not required in stop-market mode.
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// Using balances for this offer. When null, use default balances. Optional
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Balances Balances { get; set; }

        /// <summary>
        /// Ignore invalid stop rate. Prepare for add new offer that can be implemented immedietly.
        /// </summary>
        [JsonProperty("ignoreInvalidStopRate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IgnoreInvalidStopRate { get; set; }

        /// <summary>
        /// Set stop limit offer temple.
        /// </summary>
        /// <param name="offerType">Offer type string: BUY/SELL.</param>
        /// <param name="amount">Amount of currencies.</param>
        /// <param name="stopRate">Stop rate, when offer will be added to orderbook.</param>
        /// <param name="rate">Offer rate.</param>
        public void SetStopLimitOffer(string offerType, decimal amount, decimal stopRate, decimal rate)
        {
            OfferType = offerType;
            Amount = amount;
            StopRate = stopRate;
            Mode = ExchangeBasicData.OfferType.STOP_LIMIT.ToLowerString();
            Rate = rate;
        }

        /// <summary>
        /// Set quick sell/buy offer, activated when stop rate will be achieved.
        /// </summary>
        /// <param name="offerType">Offer type string: BUY/SELL.</param>
        /// <param name="amount">Amount of currencies.</param>
        /// <param name="stopRate">Stop rate, when offer will be added to orderbook.</param>
        public void SetStopMarketOffer(string offerType, decimal amount, decimal stopRate)
        {
            OfferType = offerType;
            Amount = amount;
            StopRate = stopRate;
            Mode = ExchangeBasicData.OfferType.STOP_MARKET.ToLowerString();
        }

        /// <summary>
        /// Set stop market offer, with ignoring invalid stop rate (the offer can be realized immediately).
        /// </summary>
        /// <param name="offerType">Offer type string: BUY/SELL.</param>
        /// <param name="amount">Amount of currencies.</param>
        /// <param name="stopRate">Stop rate, when offer will be added to orderbook.</param>
        public void SetIgnoreInvalidStopRateOffer(string offerType, decimal amount, decimal stopRate)
        {
            SetStopMarketOffer(offerType, amount, stopRate);
            IgnoreInvalidStopRate = true;
        }

        /// <summary>
        /// Set stop limit offer with custo balances identificators.
        /// </summary>
        /// <param name="offerType">Offer type string: BUY/SELL.</param>
        /// <param name="amount">Amount of currencies.</param>
        /// <param name="stopRate">Stop rate, when offer will be added to orderbook.</param>
        /// <param name="rate">Offer rate.</param>
        /// <param name="balances">Balances object (first and second wallet).</param>
        public void SetStopLimitSpecifyOffer(string offerType, decimal amount, decimal stopRate, decimal rate, Balances balances)
        {
            SetStopLimitOffer(offerType, amount, stopRate, rate);
            Balances = balances;
        }
    }
}
