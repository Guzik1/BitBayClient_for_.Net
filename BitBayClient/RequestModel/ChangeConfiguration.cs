using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// Data model for send to change default walets.
    /// </summary>
    public class ChangeConfiguration
    {
        /// <summary>
        /// UUID first balance walet.
        /// </summary>
        public string First { get; set; }

        /// <summary>
        /// UUID second balance walet.
        /// </summary>
        public string Second { get; set; }

        internal ChangeConfiguration(string first, string second)
        {
            First = first;
            Second = second;
        }
    }
}
