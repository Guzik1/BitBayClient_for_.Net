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
    public class History
    {
        Config config;

        internal History(Config config)
        {
            this.config = config;
        }

        #region TransactionHistory
        /// <summary>
        /// Get transaction history from user account. For use, must authorize User.
        /// </summary>
        /// <param name="body">Transaction history body request.</param>
        /// <returns>Transaction history object.</returns>
        /// <exception cref="ArgumentException">Throw when body parameter is null.</exception>
        public TransactionHistory GetTransactionHistory(TransactionHistoryRequest body)
        {
            if (body == null)
                throw new ArgumentException("The body params can not be null!");

            return SendGetTransactionHistoryRequest(body);
        }

        TransactionHistory SendGetTransactionHistoryRequest(TransactionHistoryRequest body)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "history/transactions");

            rc.AddQuery(body);
            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return Tools.TryGetResponse<TransactionHistory>(rc);
        }
        #endregion

        #region OperationHistory
        /// <summary>
        /// Get operation history from user account on exchange. For use, must authorize User.
        /// </summary>
        /// <param name="request">Operation history request object.</param>
        /// <returns>Operation history.</returns>
        /// <exception cref="ArgumentException">Throw when body parameter is null.</exception>
        public OperationHistory GetOperationHistory(OperationHistoryRequest request)
        {
            if (request == null)
                throw new ArgumentException("The request params can not be null!");

            return SendGetOperationHistoryRequest(request);
        }

        OperationHistory SendGetOperationHistoryRequest(OperationHistoryRequest request)
        {
            RestClient rc = new RestClient(config.ApiBalancesUrl + "history");

            rc.AddQuery(request);
            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return Tools.TryGetResponse<OperationHistory>(rc);
        }
        #endregion
    }
}
