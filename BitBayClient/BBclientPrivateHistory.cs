using System;
using System.Collections.Generic;
using System.Text;
using BitBayClient.RequestModel;
using BitBayClient.RequestModel.Temp;
using BitBayClient.ResponseModel;
using BitBayClient.ResponseModel.Temp;
using RestApiClient;

namespace BitBayClient
{
    public partial class BitBayClient
    {
        #region TransactionHistory
        public TransactionHistory GetTransactionHistory(TransactionHistoryRequest body)
        {
            if (body == null)
                throw new ArgumentException("The body params can not be null!");

            return SendGetTransactionHistoryRequest(body);
        }

        TransactionHistory SendGetTransactionHistoryRequest(TransactionHistoryRequest body)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "history/transactions");

            TransactionHistoryRequestTemp queryRequest = new TransactionHistoryRequestTemp();
            queryRequest.SetRequest(body);

            rc.AddQuery(body);
            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return TryGetResponse<TransactionHistory>(rc);
        }
        #endregion

        #region OperationHistory

        // TODO: add operation history.
        #endregion
    }
}
