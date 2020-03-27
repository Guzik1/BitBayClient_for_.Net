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

            rc.AddQuery(body);
            rc.AddOwnHeaderToRequest(new AutorizeData(config));
            rc.SendGET();

            return TryGetResponse<TransactionHistory>(rc);
        }
        #endregion

        #region OperationHistory
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

            return TryGetResponse<OperationHistory>(rc);
        }
        #endregion
    }
}
