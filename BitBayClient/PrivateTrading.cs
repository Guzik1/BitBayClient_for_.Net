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
    public class PrivateTrading
    {
        Config config;

        internal PrivateTrading(Config config)
        {
            this.config = config;
        }

        #region AddOffer
        public NewOffer AddNewOffer(string currencyPair, NewOfferRequest body)
        {
            if (body == null)
                throw new ArgumentException("The body params can not be null!");

            return SendAddNewOfferRequest(currencyPair, body);
        }

        ResponseModel.NewOffer SendAddNewOfferRequest(string url, NewOfferRequest body)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "offer/" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPOST(body);

            return Tools.TryGetResponse<NewOffer>(rc);
        }
        #endregion

        #region ActiveOffer
        public ActiveOffers GetAllActiveOffer()
            => SendGetActiveOffer();

        public ActiveOffers GetActiveOffer(string currencyPair)
            => SendGetActiveOffer("/" + currencyPair);

        ActiveOffers SendGetActiveOffer(string url = "")
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "offer" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return Tools.TryGetResponse<ActiveOffers>(rc);
        }
        #endregion

        #region DeleteOffer
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
        public CommissionAndConfig GetCommissionsAndConfiguration(string currencyPair)
            => SendGetCommissionsAndConfigRequest(currencyPair);

        CommissionAndConfig SendGetCommissionsAndConfigRequest(string url)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "config/" + url);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return Tools.TryGetResponse<CommissionAndConfig>(rc);
        }
        #endregion

        #region ChangeConfiguration
        public bool ChangeConfiguration(string currencyPair, ChangeConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentException("The body params can not be null!");

            return SendChangeConfigurationRequest(currencyPair, configuration);
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
