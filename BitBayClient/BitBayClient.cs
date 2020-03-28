using BitBayClient.Converters;
using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using BitBayClient.ResponseModel.Temp;
using CurrencyPair;
using ExchangeBasicData;
using RestApiClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    /// <summary>
    /// Client for BitBay stock exchange.
    /// </summary>
    public partial class BitBayClient
    {
        Config config = new Config();

        /// <summary>
        /// Public trading api method.
        /// </summary>
        public PublicTrading PublicTrading;

        /// <summary>
        /// Private trading api method.
        /// </summary>
        public PrivateTrading PrivateTrading;

        /// <summary>
        /// Private stop trading api method.
        /// </summary>
        public PrivateStopTrading PrivateStopTrading;

        /// <summary>
        /// Historical api method.
        /// </summary>
        public History History;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public BitBayClient()
        {
            PublicTrading = new PublicTrading(config);
            PrivateTrading = new PrivateTrading(config);
            PrivateStopTrading = new PrivateStopTrading(config);
            History = new History(config);
        }
    }
}
