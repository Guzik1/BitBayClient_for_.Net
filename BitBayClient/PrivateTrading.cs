using BitBayClient.Internal;
using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using ExchangeBasicData;
using RestApiClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    /// <summary>
    /// Private trading method on BitBay stock exchange, for use must autorize user using Public and Private key.
    /// </summary>
    public class PrivateTrading
    {
        Config config;

        internal PrivateTrading(Config config)
        {
            this.config = config;
        }

        #region AddOffer
        /// <summary>
        /// Add new offer, using NewOfferRequest body and sepcif currency pair code. For use must autorize User.
        /// </summary>
        /// <param name="currencyPair">Currency pair code string.</param>
        /// <param name="body">New offer body request.</param>
        /// <returns>New offer response.</returns>
        /// <exception cref="ArgumentException">Throw on event, the body params was null.</exception>
        public NewOffer AddNewOffer(string currencyPair, NewOfferRequest body)
        {
            if (body == null)
                throw new ArgumentException("The body params can not be null!");

            return SendAddNewOfferRequest(currencyPair, body);
        }

        NewOffer SendAddNewOfferRequest(string url, NewOfferRequest body)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "offer/" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPOST(body);

            return Tools.TryGetResponse<NewOffer>(rc);
        }
        #endregion

        #region ActiveOffer
        /// <summary>
        /// Get all active offer from stock exchange on user account. For use must autorize User.
        /// </summary>
        /// <returns>List of all active offers.</returns>
        public List<ActiveOffer> GetAllActiveOffer()
            => SendGetActiveOffer().ActiveOffer;

        /// <summary>
        /// Get all active offer from specif market. For use must autorize User.
        /// </summary>
        /// <param name="currencyPair">Currency pair code.</param>
        /// <returns>List of all active offers on currencyPair market.</returns>
        public List<ActiveOffer> GetActiveOffer(string currencyPair)
            => SendGetActiveOffer("/" + currencyPair).ActiveOffer;

        ActiveOffers SendGetActiveOffer(string url = "")
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "offer" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return Tools.TryGetResponse<ActiveOffers>(rc);
        }
        #endregion

        #region DeleteOffer
        /// <summary>
        /// Delete offer from market. For use must autorize User.
        /// </summary>
        /// <param name="currencyPair">Currency pair code.</param>
        /// <param name="offerId">Offer UUID identificator, geting on offer add.</param>
        /// <param name="offerType">Offer type: buy or sell.</param>
        /// <param name="offerRate">Offer rate.</param>
        /// <returns>True if offer was deleted succesfull or false else.</returns>
        public bool DeleteOffer(string currencyPair, string offerId, TransactionType offerType, decimal offerRate)
            => SendDeleteOffer($"{ currencyPair }/{ offerId }/{ offerType.ToLowerString() }/{ offerRate }");

        bool SendDeleteOffer(string url)
        {
            RestClient rm = new RestClient(config.ApiTradingUrl + "offer/" + url);

            rm.AddOwnHeaderToRequest(new AutorizeData(config));
            rm.SendDELETE();

            if (Tools.CheckResult(rm))
                return true;

            return false;
        }
        #endregion

        #region GetCommissionsAndConfiguration
        /// <summary>
        /// Get commisions and configuration assinged to the account. For use must autorize User.
        /// </summary>
        /// <param name="currencyPair">Currency pair code.</param>
        /// <returns>Commision and configuration data object.</returns>
        public CommissionAndConfig GetCommissionsAndConfiguration(string currencyPair)
            => SendGetCommissionsAndConfigRequest(currencyPair).Config;

        CommissionAndConfigPre SendGetCommissionsAndConfigRequest(string url)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "config/" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return Tools.TryGetResponse<CommissionAndConfigPre>(rc);
        }
        #endregion

        #region ChangeConfiguration
        /// <summary>
        /// Change default ballance on market. For use must autorize User. Pair build first-second, for example BTC-USD btc is first, usd is second.
        /// </summary>
        /// <param name="currencyPair">Currency pair code.</param>
        /// <param name="ballanceIdForFirstCurrence">Balance UUID for first currency in pair.</param>
        /// <param name="BallanceIdForSecondCurrence">Balance UUID for second currency in pair</param>
        /// <returns>Return true if change configuration successful or return false else.</returns>
        public bool ChangeConfiguration(string currencyPair, string ballanceIdForFirstCurrence, string BallanceIdForSecondCurrence)
        {
            ChangeConfiguration chc = new ChangeConfiguration(ballanceIdForFirstCurrence, BallanceIdForSecondCurrence);

            return SendChangeConfigurationRequest(currencyPair, chc);
        }

        bool SendChangeConfigurationRequest(string pair, ChangeConfiguration configuration)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "config/" + pair);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPOST(configuration);

            return rc.ResponseHasNoErrors(new ResponseChecker());
        }
        #endregion
    }
}
