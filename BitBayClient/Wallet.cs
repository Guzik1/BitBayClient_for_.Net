using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using RestApiClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    /// <summary>
    /// History object to get historical account's data through BitBay api.
    /// </summary>
    public class Wallet
    {
        Config config;

        internal Wallet(Config config)
        {
            this.config = config;
        }

        #region WalletList
        /// <summary>
        /// Get all wallet list from user account. For use, must authorize User.
        /// </summary>
        /// <returns></returns>
        public List<WalletItem> GetWalletList()
        {
            RestClient rc = new RestClient(config.ApiDoubleBalancesUrl);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return Tools.TryGetResponse<WalletList>(rc).Balances;
        }
        #endregion

        #region NewWallet
        /// <summary>
        /// Create new wallet on user account. For use, must authorize User
        /// </summary>
        /// <param name="currencyCode">Currency code.</param>
        /// <param name="name">Wallet name</param>
        /// <param name="walletType">Wallet type: crypto/fiat.</param>
        /// <returns>Created wallet data.</returns>
        public WalletItem CreateNewWallet(string currencyCode, string name, WalletType walletType)
        {
            RestClient rc = new RestClient(config.ApiDoubleBalancesUrl);

            NewWalletRequest nw = new NewWalletRequest(currencyCode, walletType.ToString(), name);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPOST(nw);

            return Tools.TryGetResponse<WalletList>(rc).Balances[0];
        }
        #endregion

        #region WalletChangeName
        /// <summary>
        /// Change wallet name on user account. For use, must authorize User
        /// </summary>
        /// <param name="identificator">Wallet UUID identificator.</param>
        /// <param name="newName">New wallet name.</param>
        /// <returns>True if wallet name was changed succesfull or false else.</returns>
        public bool ChangeWalletName(string identificator, string newName)
        {
            RestClient rc = new RestClient(config.ApiDoubleBalancesUrl + "/" + identificator);

            ChangeWalletName chwn = new ChangeWalletName(newName);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPUT(chwn);

            if (Tools.CheckResult(rc))
                return true;

            return false;
        }
        #endregion

        #region InternalTransfer
        /// <summary>
        /// Internal transfer funds between two wallet. For use, must authorize User
        /// </summary>
        /// <param name="sourceId">Wallet source UUID identificator.</param>
        /// <param name="destinationId">Wallet destination UUID identificator.</param>
        /// <param name="currencyCode">Currency market code.</param>
        /// <param name="funds">Amount of funds to transfer.</param>
        /// <returns>Transfer data, confirmation.</returns>
        public InternalTransfer InternalTransfer(string sourceId, string destinationId, string currencyCode, decimal funds)
        {
            RestClient rc = new RestClient(config.ApiDoubleBalancesUrl + "/transfer/" + sourceId + "/" + destinationId);

            InternalTransferRequest itr = new InternalTransferRequest(currencyCode, funds);

            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendPOST(itr);

            return Tools.TryGetResponse<InternalTransfer>(rc);
        }
        #endregion
    }
}
