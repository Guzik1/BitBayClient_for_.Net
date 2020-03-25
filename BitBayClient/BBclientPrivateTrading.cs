using BitBayClient.ResponseModel;
using BitBayClient.RequestModel;
using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;
using RestApiClient;
using BitBayClient.RequestModel.Temp;
using BitBayClient.ResponseModel.Temp;
using ExchangeBasicData;
using BitBayClient.Internal;

namespace BitBayClient
{
    public partial class BitBayClient
    {
        #region AddOffer
        public NewOffer AddNewOffer(Pair pair, NewOfferRequest body)
        {
            if (body == null)
                throw new ArgumentException("The body params can not be null!");

            return SendAddNewOfferRequest(pair.ToStringWithDash(), body);
        }

        ResponseModel.NewOffer SendAddNewOfferRequest(string url, NewOfferRequest body)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "offer/" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPOST(body);

            return TryGetResponse<NewOffer>(rc);
        }
        #endregion

        #region ActiveOffer
        public ActiveOffers GetAllActiveOffer()
            => SendGetActiveOffer();

        public ActiveOffers GetActiveOffer(Pair pair)
            => SendGetActiveOffer("/" + pair.ToStringWithDash());

        ActiveOffers SendGetActiveOffer(string url = "")
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "offer" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return TryGetResponse<ActiveOffers>(rc);
        }
        #endregion

        #region DeleteOffer
        public bool DeleteOffer(Pair pair, string offerId, TransactionType offerType, decimal offerRate)
            => SendDeleteOffer($"{ pair.ToStringWithDash() }/{ offerId }/{ offerType.ToLowerString() }/{ offerRate }");

        bool SendDeleteOffer(string url)
        {
            RestClient rm = new RestClient(config.ApiTradingUrl + "offer/" + url);

            rm.AddOwnHeaderToRequest(new AutorizeData(config));
            rm.SendDELETE();

            if (CheckResult(rm))
                return true;

            return false;
        }
        #endregion

        #region GetCommissionsAndConfiguration
        public CommissionAndConfig GetCommissionsAndConfiguration(Pair pair)
            => SendGetCommissionsAndConfigRequest(pair.ToStringWithDash());

        CommissionAndConfig SendGetCommissionsAndConfigRequest(string url)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "config/" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return TryGetResponse<CommissionAndConfig>(rc);
        }
        #endregion

        #region ChangeConfiguration
        public bool SendChangeConfiguration(Pair pair, ChangeConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentException("The body params can not be null!");

            return SendChangeConfigurationRequest(pair.ToStringWithDash(), configuration);
        }

        public bool SendChangeConfigurationRequest(string pair, ChangeConfiguration configuration)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "config/" + pair);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPOST(configuration);

            return rc.ResponseHasNoErrors(new ResponseChecker());
        }
        #endregion
    }
}
