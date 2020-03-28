using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// Limits of orderbook result enumerion.
    /// </summary>
    public enum OrderbookLimits
    {
        /// <summary>Limit 10 transaction.</summary>
        Limit10 = 10,
        /// <summary>Limit 50 transaction.</summary>
        Limit50 = 50,
        /// <summary>Limit 100 transaction.</summary>
        Limit100 = 100,
    }

    /// <summary>
    /// Extension class for OrderbookLimits enum.
    /// </summary>
    public static class OrderbookLimitExtensions
    {
        /// <summary>
        /// Convert OrderbookLimit to int of number limit.
        /// </summary>
        /// <param name="limit">OrderbookLimit enum.</param>
        /// <returns>Limit number.</returns>
        public static int ToInt(this OrderbookLimits limit)
        {
            return (int)limit;
        }
    }
}
