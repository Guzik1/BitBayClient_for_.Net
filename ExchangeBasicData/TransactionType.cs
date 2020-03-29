using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeBasicData
{
    public enum TransactionType
    {
        BUY,
        SELL
    }

    public static class TransactionTypeExtensions
    {
        public static TransactionType Parse(string name)
        {
            return (TransactionType)Enum.Parse(typeof(TransactionType), name, true);
        }

        public static int ToInt(this TransactionType type)
        {
            return (int)type;
        }

        public static string ToLowerString(this TransactionType type)
        {
            return type.ToString().ToLower();
        }
    }
}
