using BitBayClient.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// This data model is response on <see cref="History.GetOperationHistory(RequestModel.OperationHistoryRequest)"/> request.
    /// <seealso cref="OperationHistoryItem"/>
    /// </summary>
    public class OperationHistory
    {
        /// <summary>
        /// List of operation history items.
        /// </summary>
        public List<OperationHistoryItem> Items { get; set; }

        /// <summary>
        /// Is there another operation history page.
        /// </summary>
        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// Count of download history rows.
        /// </summary>
        public int FetchedRows { get; set; }

        /// <summary>
        /// Actual rows limit.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Object of parameters about the filters used in the query.
        /// </summary>
        public OperationHistorySettings Settings { get; set; }
    }

    /// <summary>
    /// Represent operation history one item.
    /// </summary>
    public class OperationHistoryItem
    {
        /// <summary>
        /// Record UUID identificator.
        /// </summary>
        [JsonProperty("historyId")]
        public string HistoryId { get; set; }

        /// <summary>
        /// Details for wallet.
        /// </summary>
        public Balance Balance { get; set; }

        /// <summary>
        /// Operation unique UUID identificator.
        /// </summary>
        public string DetailId { get; set; }

        /// <summary>
        /// Creation time record (unix timestamp)
        /// </summary>
        public long Time { get; set; }

        /// <summary>
        /// Operation type string.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Operation type, convert from Type to OpeartionTypes enum.
        /// </summary>
        public OperationTypes OperationType { get => EnumConverter.Parse<OperationTypes>(Type); }

        /// <summary>
        /// The value of the operation.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Founds before this operation.
        /// </summary>
        [JsonProperty("foudsBefore")]
        public FoudsStep FoundsBefore { get; set; }

        /// <summary>
        /// Founds after this operation.
        /// </summary>
        [JsonProperty("fundsAfter")]
        public FoudsStep FoundsAfter { get; set; }

        /// <summary>
        /// Founds change in this operation.
        /// </summary>
        public FoudsStep Change { get; set; }
    }

    /// <summary>
    /// Data model for one wallet.
    /// </summary>
    public class Balance
    {
        /// <summary>
        /// UUID identificator balance.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Currency code.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Wallet type string, one option between: crypto and fiat.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Wallet types, convert from Type string.
        /// </summary>
        public WalletType WalletType { get => EnumConverter.Parse<WalletType>(Type); }

        /// <summary>
        /// Unique user UUID identificator.
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Wallet name.
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// Represent founds before, after and chagne, on wallet.
    /// </summary>
    public class FoudsStep
    {
        /// <summary>
        /// Total amount of founds.
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Avaliable amount of founds.
        /// </summary>
        [JsonProperty("avalilable")]
        public decimal Avaliable { get; set; }

        /// <summary>
        /// Locked amount of founds.
        /// </summary>
        public decimal Locked { get; set; }
    }

    /// <summary>
    /// Represent settings of filters used in the request query.
    /// </summary>
    public class OperationHistorySettings
    {
        /// <summary>
        /// List of banaces UUID identificator, for which history was returned.
        /// </summary>
        [JsonProperty("balancesId")]
        public List<string> BalancesId { get; set; }

        /// <summary>
        /// List of currencies, for which history was returned.
        /// </summary>
        [JsonProperty("balanceCurrencies")]
        public List<string> BalanceCurrencies { get; set; }

        /// <summary>
        /// List of balance types, for which history was returned.
        /// </summary>
        [JsonProperty("balanceTypes")]
        public List<string> BalanceTypes { get; set; }

        /// <summary>
        /// Name of application, which concerns wallet. Available name: BITBAY / BITBAYPAY
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Name of application, which concerns wallet, convert from Engine string.
        /// </summary>
        public ApplicationList EngineBalances { get => EnumConverter.Parse<ApplicationList>(Engine); }

        /// <summary>
        /// The time from which we want to download the history.
        /// </summary>
        public long FromTime { get; set; }

        /// <summary>
        /// The time to which we want to download the history.
        /// </summary>
        public long ToTime { get; set; }

        /// <summary>
        /// Filtering for absolute values for <see cref="FromValue"/> and <see cref="ToValue"/>.
        /// </summary>
        public bool AbsValue { get; set; }

        /// <summary>
        /// Minimal amount of currencies, which we want to download the history.
        /// </summary>
        public decimal FromValue { get; set; }

        /// <summary>
        /// Maximal amount of currencies, which we want to download the history.
        /// </summary>
        public decimal ToValue { get; set; }

        /// <summary>
        /// Sort settings params.
        /// </summary>
        public SortHistorySettings Sort { get; set; }

        /// <summary>
        /// Type of operation, which we want to download the history.
        /// </summary>
        public List<string> Types { get; set; }
    }

    /// <summary>
    /// Represent sorted settings.
    /// </summary>
    public class SortHistorySettings
    {
        /// <summary>
        /// Select field to sort by this field. Example: time.
        /// </summary>
        public string By { get; set; }

        /// <summary>
        /// String order by field.
        /// </summary>
        [JsonProperty("order")]
        public string OrderString { get => Order.ToString(); }

        /// <summary>
        /// Sort after ASC or DESC, convert from OrderString.
        /// </summary>
        [JsonIgnore]
        public SortOrderTypes Order { get => EnumConverter.Parse<SortOrderTypes>(OrderString); }

    }

}
