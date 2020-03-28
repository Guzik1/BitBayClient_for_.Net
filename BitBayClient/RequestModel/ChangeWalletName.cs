using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// Data model for request to Put change balance name.
    /// </summary>
    public class ChangeWalletName
    {
        /// <summary>
        /// New wallet name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Constructor to set new name.
        /// </summary>
        /// <param name="name"></param>
        public ChangeWalletName(string name)
        {
            Name = name;
        }
    }
}
