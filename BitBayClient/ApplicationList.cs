using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    public enum ApplicationList
    {
        BITBAY,
        BITBAYPAY
    }

    public static class ApplicationListExtensions
    {
        public static ApplicationList Parse(string name)
        {
            return (ApplicationList)Enum.Parse(typeof(ApplicationList), name, true);
        }
    }
}