using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeBasicData
{
    public enum OfferType
    {
        Limit,
        Market,

        Stop_limit,
        Stop_market
    }

    public static class OfferTypeExtension
    {
        public static OfferType Parse(string name)
        {
            string toParse = name.Replace('-', '_');

            return (OfferType)Enum.Parse(typeof(OfferType), toParse, true);
        }

        public static string ToLowerString(this OfferType offerType)
        {
            string output = offerType.ToString().ToLower();

            return output.Replace('_', '-');
        }
    }
}
