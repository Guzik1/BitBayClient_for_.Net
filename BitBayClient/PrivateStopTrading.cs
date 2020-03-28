using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using RestApiClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    public class PrivateStopTrading
    {
        Config config;

        internal PrivateStopTrading(Config config)
        {
            this.config = config;
        }

        #region AddStopOffer
        public NewStopOffer AddNewStopOffer(string currencyPair, NewStopOfferRequest body)
        {
            if (body == null)
                throw new ArgumentException("The body params can not be null!");

            return SendAddNewStopOfferRequest(currencyPair, body);
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
        public ActiveStopOffers GetActiveStopOffer()
            => SendGetActiveStopOfferRequest();

        public ActiveStopOffers GetActiveStopOffer(string currencyPair)
            => SendGetActiveStopOfferRequest("/" + currencyPair);

        ActiveStopOffers SendGetActiveStopOfferRequest(string url = "")
        {
            RestClient rc = new RestClient(config.ApiTradingStopUrl + "offer" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return Tools.TryGetResponse<ActiveStopOffers>(rc);
        }
        #endregion

        #region DeleteStopOffer
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
