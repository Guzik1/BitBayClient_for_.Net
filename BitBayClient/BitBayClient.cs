using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    /// <summary>
    /// Client for BitBay stock exchange.
    /// </summary>
    public class BitBayClient
    {
        Config config = new Config();
        bool autorized = false;

        /// <summary>
        /// Public trading api methods.
        /// </summary>
        public PublicTrading PublicTrading { get; private set; }

        /// <summary>
        /// Private trading api methods.
        /// </summary>
        public PrivateTrading PrivateTrading 
        {
            get
            {
                if (!autorized)
                    ThrowUnauthorizedException();

                return _privateTrading;
            }
        }
        PrivateTrading _privateTrading;

        /// <summary>
        /// Private stop trading api methods.
        /// </summary>
        public PrivateStopTrading PrivateStopTrading
        {
            get
            {
                if (!autorized)
                    ThrowUnauthorizedException();

                return _privateStopTrading;
            }
        }
        PrivateStopTrading _privateStopTrading;

        /// <summary>
        /// Historical api methods.
        /// </summary>
        public History History
        {
            get
            {
                if (!autorized)
                    ThrowUnauthorizedException();

                return _history;
            }
        }
        History _history;

        /// <summary>
        /// Historical api methods.
        /// </summary>
        public Wallet Balances
        {
            get
            {
                if (!autorized)
                    ThrowUnauthorizedException();

                return _wallet;
            }
        }
        Wallet _wallet;

        void ThrowUnauthorizedException()
        {
            throw new Exception("Unautorized user, use SetAutorizationData method to autorize.");
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public BitBayClient()
        {
            Inicjalize();
        }

        /// <summary>
        /// Constructio inicjalize objects and call to SetAutorizationData(publicKey, privateKey) method.
        /// </summary>
        /// <param name="publicKey">Public api key.</param>
        /// <param name="privateKey">Private api key.</param>
        public BitBayClient(string publicKey, string privateKey)
        {
            Inicjalize();
            SetAutorizationData(publicKey, privateKey);
        }

        void Inicjalize()
        {
            PublicTrading = new PublicTrading(config);
            _privateTrading = new PrivateTrading(config);
            _privateStopTrading = new PrivateStopTrading(config);
            _history = new History(config);
            _wallet = new Wallet(config);
        }

        /// <summary>
        /// Set autorization data for client.
        /// </summary>
        /// <param name="publicKey">Public api key.</param>
        /// <param name="privateKey">Private api key.</param>
        public void SetAutorizationData(string publicKey, string privateKey)
        {
            config.PublicKey = publicKey;
            config.PrivateKey = privateKey;

            autorized = true;
        }
    }
}
