using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using RestApiClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    /// <summary>
    /// Private stop trading api method on BitBay stock exchange, for use must autorize user using Public and Private key.
    /// </summary>
    public class PrivateStopTrading
    {
        Config config;

        internal PrivateStopTrading(Config config)
        {
            this.config = config;
        }

        #region AddStopOffer
        /// <summary>
        /// Add new stop offer to user account. For use, must authorize User.
        /// </summary>
        /// <param name="currencyPair">Currency pair code.</param>
        /// <param name="body">New offer body.</param>
        /// <returns>Offer UUID identificator.</returns>
        public string AddNewStopOffer(string currencyPair, NewStopOfferRequest body)
        {
            if (body == null)
                throw new ArgumentException("The body params can not be null!");

            return SendAddNewStopOfferRequest(currencyPair, body).StopOfferId;
        }

        NewStopOffer SendAddNewStopOfferRequest(string url, NewStopOfferRequest body)
        {
            RestClient rc = new RestClient(config.ApiTradingStopUrl + "offer/" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPOST(body);

            return Tools.TryGetResponse<NewStopOffer>(rc);
        }
        #endregion

        #region ActiveStopOffer
        /// <summary>
        /// Get all active stop offer on exchange.
        /// </summary>
        /// <returns>List of active stop offers.</returns>
        public List<ActiveStopOffer> GetActiveStopOffer()
            => SendGetActiveStopOfferRequest();

        /// <summary>
        /// Get active stop offer for specif market.
        /// </summary>
        /// <param name="currencyPair">Currency pair code.</param>
        /// <returns>List of active stop offers.</returns>
        public List<ActiveStopOffer> GetActiveStopOffer(string currencyPair)
            => SendGetActiveStopOfferRequest("/" + currencyPair);

        List<ActiveStopOffer> SendGetActiveStopOfferRequest(string url = "")
        {
            RestClient rc = new RestClient(config.ApiTradingStopUrl + "offer" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return Tools.TryGetResponse<ActiveStopOffers>(rc).ActiveOffer;
        }
        #endregion

        #region DeleteStopOffer
        /// <summary>
        /// Delete specif offer UUID on specif currency pair.
        /// </summary>
        /// <param name="currencyPair">Currency pair code.</param>
        /// <param name="offerId">Offer UUID identificator.</param>
        /// <returns>Return true if delete stop offer successful or return false else.</returns>
        public bool DeleteStopOffer(string currencyPair, string offerId)
            => DeleteStopOfferRequest($"{ currencyPair }/{ offerId }");

        bool DeleteStopOfferRequest(string url)
        {
            RestClient rm = new RestClient(config.ApiTradingStopUrl + "offer/" + url);

            rm.AddOwnHeaderToRequest(new AutorizeData(config));
            rm.SendDELETE();

            if (Tools.CheckResult(rm))
                return true;

            return false;
        }
        #endregion
    }
}
