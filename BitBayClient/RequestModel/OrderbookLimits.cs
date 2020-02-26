using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    public enum OrderbookLimits
    {
        Limit10 = 10,
        Limit50 = 50,
        Limit100 = 100,
    }

    public static class OrderbookLimitExtensions
    {
        public static int ToInt(this OrderbookLimits limit)
        {
            return (int)limit;
        }
    }
}
