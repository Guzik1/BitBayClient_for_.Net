using BitBayClient.Converters;
using ExchangeBasicData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    internal class LastTransactionsTemp: IResponseConvert<LastTransactions>
    {
        [JsonProperty("items")]
        public List<LastTransactionItemTemp> LastTransaction { get; set; }

        public DateTime RequestTime { get; set; }

        public LastTransactions GetResponse()
        {
            List<LastTransactionItem> lastTransactions = new List<LastTransactionItem>();

            for(int i = 0; i < LastTransaction.Count; i++)
            {
                LastTransactionItem lti = new LastTransactionItem(
                    LastTransaction[i].Id,
                    Date.Convert(LastTransaction[i].Timestamp),
                    LastTransaction[i].Amount,
                    LastTransaction[i].PositionRate,
                    TransactionTypeExtensions.Parse(LastTransaction[i].TransactionType)
                );

                lastTransactions.Add(lti);
            }

            return new LastTransactions(lastTransactions);
        }
    }

    internal class LastTransactionItemTemp
    {
        public string Id { get; set; }

        [JsonProperty("t")]
        public long Timestamp { get; set; }

        [JsonProperty("a")]
        public decimal Amount { get; set; }

        [JsonProperty("r")]
        public decimal PositionRate { get; set; }

        [JsonProperty("ty")]
        public string TransactionType { get; set; }
    }
}
