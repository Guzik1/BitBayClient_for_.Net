using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    public class ChangeWalletName
    {
        public string Name { get; set; }

        public ChangeWalletName(string name)
        {
            Name = name;
        }
    }
}
