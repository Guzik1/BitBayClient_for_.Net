using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// Data model for new offer request (<see cref="PrivateTrading.AddNewOffer(string, NewOfferRequest)"/>) to exchange.
    /// </summary>
    public class NewOfferRequest
    {
        /// <summary>
        /// Amount of currency in position. REQUIRED
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Offer rate (price). REQUIRED
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// Use only in market offer, replaces rate. Opcjonal
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal Price { get; set; }

        /// <summary>
        /// Type of offer: buy or sell. REQUIRED
        /// </summary>
        [JsonProperty("offerType")]
        public string OfferType { get; set; }

        /// <summary>
        /// Offer mode: limit or market. REQUIRED
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Is the offer post-only? atribute. Opcjonal
        /// </summary>
        [JsonProperty("postOnly")]
        public bool PostOnly { get; set; }

        /// <summary>
        /// Is the offer fill or kill? atribute. Opcjonal
        /// </summary>
        [JsonProperty("fillOrKill")]
        public bool FillOrKill { get; set; }

        /// <summary>
        /// Is the offer immediate or cancel? atribute. Opcjonal
        /// </summary>
        [JsonProperty("immediateOrCancel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ImmediateOrCancel { get; set; }

        /// <summary>
        /// Different UUID wallets for first currency in pair. Opcjonal
        /// </summary>
        [JsonProperty("firstBalanceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstBalanceId { get; set; }

        /// <summary>
        /// Different UUID wallets for second currency in pair. Opcjonal
        /// </summary>
        [JsonProperty("secondBalanceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SecondBalanceId { get; set; }

        /// <summary>
        /// Set quick sell or buy with const amount offer.
        /// </summary>
        /// <param name="offerType">String offer type: BUY/SELL</param>
        /// <param name="amount">Amount of currencie.</param>
        public void SetQuickMarketConstAmountOffer(string offerType, decimal amount)
        {
            Amount = amount;
            OfferType = offerType;
            Mode = ExchangeBasicData.OfferType.MARKET.ToLowerString();
        }

        /// <summary>
        /// Set quick sell or buy with const price offer.
        /// </summary>
        /// <param name="offerType">String offer type: BUY/SELL</param>
        /// <param name="price">Price.</param>
        public void SetQuickMarketConstPriceOffer(string offerType, decimal price)
        {
            Price = price;
            OfferType = offerType;
            Mode = ExchangeBasicData.OfferType.MARKET.ToLowerString();
        }

        /// <summary>
        /// Set STANDARD offer type on exchange (default on exchange view). Set const rate and amount of currencies.
        /// </summary>
        /// <param name="offerType">String offer type: BUY/SELL</param>
        /// <param name="amount">Amount of currencies</param>
        /// <param name="rate">Offer rate</param>
        public void SetLimitOffer(string offerType, decimal amount, decimal rate)
        {
            Amount = amount;
            Rate = rate;
            OfferType = offerType;
            Mode = ExchangeBasicData.OfferType.LIMIT.ToLowerString();
        }

        /// <summary>
        /// Set post only offer data.
        /// </summary>
        /// <param name="offerType">String offer type: BUY/SELL</param>
        /// <param name="amount">Amount of currencies</param>
        /// <param name="rate">Offer rate</param>
        public void SetPostOnlyOffer(string offerType, decimal amount, decimal rate)
        {
            OfferType = offerType;
            Amount = amount;
            Rate = rate;
            Mode = ExchangeBasicData.OfferType.LIMIT.ToLowerString();
            PostOnly = true;
        }

        /// <summary>
        /// Set fill or kill offer data.
        /// </summary>
        /// <param name="offerType">String offer type: BUY/SELL</param>
        /// <param name="amount">Amount of currencies</param>
        /// <param name="rate">Offer rate</param>
        public void SetFillOrKillOffer(string offerType, decimal amount, decimal rate)
        {
            OfferType = offerType;
            Amount = amount;
            Rate = rate;
            Mode = ExchangeBasicData.OfferType.LIMIT.ToLowerString();
            FillOrKill = true;
        }

        /// <summary>
        /// Set Immediate or cancel offer data (IOC).
        /// </summary>
        /// <param name="offerType">String offer type: BUY/SELL</param>
        /// <param name="amount">Amount of currencies</param>
        /// <param name="rate">Offer rate</param>
        public void SetImmediateOrCancelOffer(string offerType, decimal amount, decimal rate)
        {
            OfferType = offerType;
            Amount = amount;
            Rate = rate;
            Mode = ExchangeBasicData.OfferType.LIMIT.ToLowerString();
            ImmediateOrCancel = true;
        }
    }
}
