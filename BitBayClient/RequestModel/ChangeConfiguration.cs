using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    public class ChangeConfiguration
    {
        public string First { get; set; }

        public string Second { get; set; }

        public ChangeConfiguration(string first, string second)
        {
            this.First = first;
            this.Second = second;
        }
    }
}
