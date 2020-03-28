using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// Data model represent balance for two currencies pair.
    /// </summary>
    public class Balances
    {
        /// <summary>
        /// First balance from currency pari, UUID identificator.
        /// </summary>
        public string First { get; set; }

        /// <summary>
        /// Second balance from currency pari, UUID identificator.
        /// </summary>
        public string Second { get; set; }
    }
}
