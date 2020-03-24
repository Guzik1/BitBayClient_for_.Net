using CurrencyPair;
using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    internal class TransactionHistoryTemp: IResponseConvert<TransactionHistory>
    {
        [JsonProperty("totalRows")]
        public int TotalRows { get; set; }

        [JsonProperty("items")]
        public List<TransactionHistoryItemTemp> Transactions { get; set; }

        [JsonProperty("nextPageCursor")]
        public string NextPageCursor { get; set; }

        public TransactionHistory GetResponse()
        {
            List<TransactionHistoryItem> transactions = new List<TransactionHistoryItem>();

            foreach(TransactionHistoryItemTemp temp in Transactions)
            {
                TransactionHistoryItem transaction = new TransactionHistoryItem()
                {
                    Id = temp.Id,
                    CurrencyPair = new Pair(temp.Market),
                    Time = Converters.Date.Convert(temp.Time),
                    Amount = temp.Amount,
                    Rate = temp.Rate,
                    InitializedBy = TransactionTypeExtensions.Parse(temp.InitialBy),
                    WasTaker = temp.WasTaker,
                    UserActionType = TransactionTypeExtensions.Parse(temp.UserActionType),
                    OfferId = temp.OfferId,
                    CommissionValue = temp.CommissionValue
                };

                transactions.Add(transaction);
            }

            return new TransactionHistory(TotalRows, transactions, NextPageCursor);
        }
    }

    internal class TransactionHistoryItemTemp
    {
        public string Id { get; set; }

        public string Market { get; set; }

        public long Time { get; set; }

        public decimal Amount { get; set; }

        public decimal Rate { get; set; }

        [JsonProperty("initializedBy")]
        public string InitialBy { get; set; }

        [JsonProperty("wasTaker")]
        public bool WasTaker { get; set; }

        [JsonProperty("userAction")]
        public string UserActionType { get; set; }

        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        [JsonProperty("commissionValue")]
        public decimal CommissionValue { get; set; }
    }
}
