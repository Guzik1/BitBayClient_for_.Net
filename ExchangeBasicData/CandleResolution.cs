using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeBasicData
{
    public enum CandleResolution
    {
        // Trading name, after = in second
        m1 = 60,
        m3 = 180,
        m5 = 300,
        m15 = 900,
        m30 = 1800,
        h1 = 3600,
        h2 = 7200,
        h4 = 14400,
        h6 = 21600,
        h12 = 43200,
        d1 = 86400,
        d3 = 259200,
        w1 = 604800,

        // biance
        h8 = 28800,
        M1 = 2628000
    }

    public static class CandleResolutionExtension
    {
        public static int GetSecond(this CandleResolution resolution)
        {
            return (int)resolution;
        }

        public static string ToString(this CandleResolution resolution)
        {
            string res = resolution.ToString();
            char first = res[0];

            return res.Substring(1) + first;
        }
    }
}
