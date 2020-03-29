using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using RestApiClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    public class Wallet
    {
        Config config;

        internal Wallet(Config config)
        {
            this.config = config;
        }

        #region WalletList
        public WalletList GetWalletList()
        {
            RestClient rc = new RestClient(config.ApiDoubleBalancesUrl);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return Tools.TryGetResponse<WalletList>(rc);
        }
        #endregion

        #region NewWallet
        public OneWallet CreateNewWallet(string currencyCode, string name, WalletType walletType)
        {
            RestClient rc = new RestClient(config.ApiDoubleBalancesUrl);

            NewWalletRequest nw = new NewWalletRequest(currencyCode, walletType.ToString(), name);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPOST(nw);

            return Tools.TryGetResponse<NewWallet>(rc).Balance;
        }
        #endregion

        #region WalletChangeName
        public bool ChangeWalletName(string identificator, string newName)
        {
            RestClient rc = new RestClient(config.ApiDoubleBalancesUrl + "/" + identificator);

            ChangeWalletName chwn = new ChangeWalletName(newName);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPUT(chwn);

            return Tools.CheckResult(rc);
        }
        #endregion

        #region InternalTransfer
        public InternalTransfer InternalTransfer(string fromId, string toId, string currencyCode, decimal funds)
        {
            RestClient rc = new RestClient(config.ApiDoubleBalancesUrl + "/transfer/" + fromId + "/" + toId);

            InternalTransferRequest itr = new InternalTransferRequest(currencyCode, funds);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPOST(itr);

            return Tools.TryGetResponse<InternalTransfer>(rc);
        }
        #endregion
    }
}
