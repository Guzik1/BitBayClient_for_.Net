using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using BitBayClient.Converters;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// All wallet list on user account.
    /// </summary>
    public class WalletList
    {
        /// <summary>
        /// List of wallets on user account.
        /// </summary>
        public List<OneWallet> Balances { get; set; }
    }

    /// <summary>
    /// New balance request.
    /// </summary>
    public class NewWallet
    {
        /// <summary>
        /// One balance.
        /// </summary>
        public OneWallet Balance { get; set; }
    }

    /// <summary>
    /// Response on request transfer funds between two balance.
    /// </summary>
    public class InternalTransfer
    {
        /// <summary>
        /// Balance wallet from transfer.
        /// </summary>
        public OneWallet From { get; set; }

        /// <summary>
        /// Balance wallet to transfer.
        /// </summary>
        public OneWallet To { get; set; }
    }

    /// <summary>
    /// Data model reperesent one wallet balance.
    /// </summary>
    public class OneWallet
    {
        /// <summary>
        /// Wallet UUID identificator
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// User UUID identificator
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Amount of funds available.
        /// </summary>
        [JsonProperty("availableFunds")]
        public decimal AvailableFunds { get; set; }

        /// <summary>
        /// Total amount of funds.
        /// </summary>
        [JsonProperty("totalFunds")]
        public decimal TotalFunds { get; set; }

        /// <summary>
        /// Locked amount of funds.
        /// </summary>
        [JsonProperty("lockedFunds")]
        public decimal LockedFunds { get; set; }

        /// <summary>
        /// Currency market code.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// String of currency code.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Wallet type: crypto/fiat, convert from Type string.
        /// </summary>
        public WalletType WalletType { get => EnumConverter.Parse<WalletType>(Type); }

        /// <summary>
        /// Wallet name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of the application supports this wallet, convert from BalanceEngineString.
        /// </summary>
        [JsonIgnore]
        public ApplicationList BalanceEngine { get; set; }

        /// <summary>
        /// String name of the application support this wallet.
        /// </summary>
        [JsonProperty("balanceEngine")]
        public string BalanceEngineString { set { BalanceEngine = EnumConverter.Parse<ApplicationList>(value); } }
    }
}
