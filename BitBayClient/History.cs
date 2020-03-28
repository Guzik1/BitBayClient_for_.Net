﻿using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using RestApiClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    public class History
    {
        Config config;

        internal History(Config config)
        {
            this.config = config;
        }

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

            return Tools.TryGetResponse<TransactionHistory>(rc);
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

            return Tools.TryGetResponse<OperationHistory>(rc);
        }
        #endregion
    }
}