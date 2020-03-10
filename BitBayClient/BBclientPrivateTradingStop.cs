using BitBayClient.RequestModel;
using BitBayClient.RequestModel.Temp;
using BitBayClient.ResponseModel;
using BitBayClient.ResponseModel.Temp;
using CurrencyPair;
using RestApiClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    public partial class BitBayClient
    {
        #region AddStopOffer
        public NewStopOffer AddNewStopOffer(Pair pair, NewStopOfferRequest body)
        {
            if (body == null)
                throw new ArgumentException("The body params can not be null!");

            return SendAddNewStopOfferRequest(pair.ToStringWithDash(), body);
        }

        NewStopOffer SendAddNewStopOfferRequest(string url, NewStopOfferRequest body)
        {
            RestClient rc = new RestClient(config.ApiTradingStopUrl + "offer/" + url);

            NewStopOfferTemp newStopOfferRequest = new NewStopOfferTemp();
            newStopOfferRequest.SetRequest(body);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPOST(newStopOfferRequest);

            return TryGetResponse<NewStopOffer>(rc);
        }
        #endregion

        #region ActiveStopOffer
        public ActiveStopOffers GetActiveStopOffer()
            => SendGetActiveStopOfferRequest();

        public ActiveStopOffers GetActiveStopOffer(Pair pair)
            => SendGetActiveStopOfferRequest("/" + pair.ToStringWithDash());

        ActiveStopOffers SendGetActiveStopOfferRequest(string url = "")
        {
            RestClient rc = new RestClient(config.ApiTradingStopUrl + "offer" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return TryGetResponse<ActiveStopOffers, ActiveStopOffersTemp>(rc);
        }
        #endregion

        #region DeleteStopOffer
        public bool DeleteStopOffer(Pair pair, string offerId)
            => DeleteStopOfferRequest($"{ pair.ToStringWithDash() }/{ offerId }");

        bool DeleteStopOfferRequest(string url)
        {
            RestClient rm = new RestClient(config.ApiTradingStopUrl + "offer/" + url);

            rm.AddOwnHeaderToRequest(new AutorizeData(config));
            rm.SendDELETE();

            if (CheckResult(rm))
                return true;

            return false;
        }
        #endregion
    }
}
