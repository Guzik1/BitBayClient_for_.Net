using ExchangeBasicData;
using System;
using System.Collections.Generic;

namespace BitBayClient.ResponseModel
{
    public class LastTransactions
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public LastTransactions() { }

        internal LastTransactions(List<LastTransactionItem> lastTransaction)
        {
            LastTransaction = lastTransaction;
        }

        public List<LastTransactionItem> LastTransaction { get; set; }

        public DateTime RequestTime { get; set; }
    }

    public class LastTransactionItem
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public LastTransactionItem() { }

        internal LastTransactionItem(string id, DateTime date, decimal amount, decimal positionRate, TransactionType type)
        {
            Id = id;
            Date = date;
            Amount = amount;
            PositionRate = positionRate;
            Type = type;
        }

        public string Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public decimal PositionRate { get; set; }

        public TransactionType Type { get; set; }
    }
}
