using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel
{
    /// <summary>
    /// Represent internal transfer body data in query to send InternalTransfer on wallets request.
    /// </summary>
    public class InternalTransferRequest
    {
        /// <summary>
        /// Currency code.
        /// </summary>
        public string Currency { get; set; }
        
        /// <summary>
        /// Amount of founds.
        /// </summary>
        public decimal Funds { get; set; }

        internal InternalTransferRequest(string currency, decimal funds)
        {
            Currency = currency;
            Funds = funds;
        }
    }
}
