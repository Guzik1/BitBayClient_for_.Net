using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    public enum WalletType
    {
        CRYPTO,
        FIAT
    }

    public static class WalletTypeExtension
    {
        public static WalletType Parse(string name)
        {
            return (WalletType)Enum.Parse(typeof(WalletType), name);
        }
    }
}
