using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
using BitBayClient.ResponseModel.Temp;
using ExchangeBasicData;
using RestApiClient;
using System;
using System.Collections.Generic;

namespace BitBayClient
{
    /// <summary>
    /// Public trading method on BitBay stock exchange.
    /// </summary>
    public class PublicTrading
    {
        Config config;

        internal PublicTrading(Config config)
        {
            this.config = config;
        }

        #region Ticker
        /// <summary>
        /// Get ticker for selected market.
        /// </summary>
        /// <param name="currencyPair">Currency pair with dash, example BTC-USD</param>
        /// <returns>Ticker for selected market. Return "ticker" atribut from api response.</returns>
        public Ticker GetTicker(string currencyPair)
            => SendGetTicer<OneTicker>("/" + currencyPair).Ticker;

        /// <summary>
        /// Get ticker for all market on stock exchange.
        /// </summary>
        /// <returns>Dictionary where key is market code, value is ticker for this market code. Return "ticker" atribut from api response.</returns>
        public Dictionary<string, Ticker> GetAllTicker()
            => SendGetTicer<Tickers>("").TickersList;

        Expected SendGetTicer<Expected>(string url)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "ticker" + url);
            rc.SendGET();

            return Tools.TryGetResponse<Expected>(rc);
        }
        #endregion

        #region Market stats
        /// <summary>
        /// Get 24 hours market stats for selected currency pair.
        /// </summary>
        /// <param name="currencePair">Currency pair code, example BTC-USD</param>
        /// <returns>24 hours stats for currency pair. Return "stats" list from response.</returns>
        public Stats GetMarketStats(string currencePair)
            => SendGetMarketStats<StatsOne>("/" + currencePair).Stats24h;

        /// <summary>
        /// Get 24 hours market stats for all market on stock exchange.
        /// </summary>
        /// <returns>Dictionary where key is currency pair code, value is stats for key market. Return "stats" list from response.</returns>
        public Dictionary<string, Stats> GetAllMarketStats()
            => SendGetMarketStats<AllStats>().Stats24h;

        Expected SendGetMarketStats<Expected>(string url = "")
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "stats" + url);
            rc.SendGET();

            return Tools.TryGetResponse<Expected>(rc);
        }
        #endregion

        #region Orderbook
        /// <summary>
        /// Get orderbook with 300 higher buy and 300 lowest sell offers, from rest api.
        /// </summary>
        /// <param name="currencyPair">Currency pair code, format example: BTC-USD.</param>
        /// <returns>Orderbook with 300 higher buy and 300 lowest sell offers.</returns>
        public Orderbook GetOrderbook(string currencyPair)
        {
            return SendGetOrderBook("orderbook/" + currencyPair);
        }

        /// <summary>
        /// Get orderbook with own limit of sell and buy offers, from rest api.
        /// </summary>
        /// <param name="currencyPair">Currency pair code, example BTC-USD.</param>
        /// <param name="limit">Limit of offer count (available limits: 10, 50, 100). Limit must be less or equal 300.</param>
        /// <returns>Orderbook with own limit offers of buy and sell.</returns>
        public Orderbook GetOrderbook(string currencyPair, OrderbookLimits limit)
        {
            return SendGetOrderBook($"orderbook-limited/{ currencyPair }/{ limit.ToInt() }");
        }

        Orderbook SendGetOrderBook(string url)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + url);
            rc.SendGET();

            return Tools.TryGetResponse<Orderbook>(rc);
        }
        #endregion

        #region Last transactions
        /// <summary>
        /// Get last 10 transaction. Return list from "items" property in api response.
        /// </summary>
        /// <param name="currencyPair">Currency pair code, example BTC-USD.</param>
        /// <returns>List of last transactions, list count 10.</returns>
        public List<LastTransactionItem> GetLastTransactions(string currencyPair)
            => SendLastTransactionsRequest(currencyPair).LastTransaction;

        /// <summary>
        ///  Get last limit count transaction. Return list from "items" property in api response.
        /// </summary>
        /// <param name="currencyPair">Currency pair code, example BTC-USD.</param>
        /// <param name="limit">Limit of result, max 300.</param>
        /// <returns>List of last transactions, list count is limited by limit (max 300).</returns>
        /// <exception cref="ArgumentException">Throw if the limit is greater than 300.</exception>
        public List<LastTransactionItem> GetLastTransactions(string currencyPair, int limit)
        {
            CheckLimitValue(limit);

            Dictionary<string, string> query = GenerateQuery(limit);

            return SendLastTransactionsRequest(currencyPair, query).LastTransaction;
        }

        /// <summary>
        /// Get last transaction, start from unixtimestamp. Return list from "items" property in api response.
        /// </summary>
        /// <param name="currencyPair">Currency pair code, example BTC-USD.</param>
        /// <param name="fromTimeUnix">Unix timestam from start geting result.</param>
        /// <returns>List of last transactions, started from unix timestamp.</returns>
        public List<LastTransactionItem> GetLastTransactions(string currencyPair, long fromTimeUnix)
        {
            Dictionary<string, string> query = GenerateQuery(timeUnix: fromTimeUnix);

            return SendLastTransactionsRequest(currencyPair, query).LastTransaction;
        }

        /// <summary>
        /// Get last limit count transaction. Return list from "items" property in api response.
        /// </summary>
        /// <param name="currencyPair">Currency pair code, example BTC-USD.</param>
        /// <param name="limit">Limit of result, max 300</param>
        /// <param name="fromTimeUnix">Unix timestam from start geting result.</param>
        /// <returns>List of last transactions, started from unix timestamp and limited by limit.</returns>
        /// <exception cref="ArgumentException">Throw if the limit is greater than 300.</exception>
        public List<LastTransactionItem> GetLastTransactions(string currencyPair, int limit, long fromTimeUnix)
        {
            CheckLimitValue(limit);

            Dictionary<string, string> query = GenerateQuery(limit, fromTimeUnix);

            return SendLastTransactionsRequest(currencyPair, query).LastTransaction;
        }

        void CheckLimitValue(int limit)
        {
            if (limit > 300)
                throw new ArgumentException("Limit must be less or equal 300.");
        }

        Dictionary<string, string> GenerateQuery(int limit = 0, long timeUnix = 0)
        {
            Dictionary<string, string> query = new Dictionary<string, string>();

            if (limit != 0)
                query.Add("limit", limit.ToString());

            if (timeUnix != 0)
                query.Add("from", timeUnix.ToString());

            return query;
        }

        LastTransactions SendLastTransactionsRequest(string path, Dictionary<string, string> query = null)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "transactions/" + path);

            if (query != null)
                rc.AddQuery(query);

            rc.SendGET();

            return Tools.TryGetResponse<LastTransactions>(rc);
        }
        #endregion

        #region Candle
        /*/// <summary>
        /// Get all candles with specif resolution for selected currencyPair.
        /// </summary>
        /// <param name="currencyPair">Currency pair code string, example BTC-USD.</param>
        /// <param name="resolution">Select candle resolution.</param>
        /// <returns>Candles data object.</returns>
        public Candles GetCandlesData(string currencyPair, CandleResolution resolution)
        {
            Candles candles = SendCandleChartDataRequest(currencyPair + "/" + resolution.GetSecond());
            candles.Resoluton = resolution;

            return candles;
        }*/

        /// <summary>
        /// Get all candles with specif resolution for selected currencyPair, start result "fromTimeUnix" and end in "toTimeUnix".
        /// For get one candle time from and time to must be the same.
        /// </summary>
        /// <param name="currencyPair">Currency pair code string, example BTC-USD.</param>
        /// <param name="resolution">Select candle resolution.</param>
        /// <param name="fromTimeUnix">Unix timestamp from start geting candles.</param>
        /// <param name="toTimeUnix">Unix timestamp to end geting candles.</param>
        /// <returns>Candles data object.</returns>
        /// <exception cref="ArgumentException">Throw if "fromTimeUnix" is great than "toTimeUnix". From time must be before to time.</exception>
        public Candles GetCandlesData(string currencyPair, CandleResolution resolution, long fromTimeUnix, long toTimeUnix)
        {
            if (fromTimeUnix > toTimeUnix)
                throw new ArgumentException("Date to must be leter(not equal) than date from!");

            Dictionary<string, string> query = CreateCandleQuery(fromTimeUnix, toTimeUnix, resolution.GetSecond());

            Candles candles = SendCandleChartDataRequest(currencyPair + "/" + resolution.GetSecond(), query);
            candles.Resoluton = resolution;

            return candles;
        }

        Dictionary<string, string> CreateCandleQuery(long from, long to, int resolutionSecond)
        {
            Dictionary<string, string> query = new Dictionary<string, string>();

            query.Add("from", from.ToString());
            query.Add("to", to.ToString());

            return query;
        }

        Candles SendCandleChartDataRequest(string path, Dictionary<string, string> query = null)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "candle/history/" + path);

            if (query != null)
                rc.AddQuery(query);

            rc.SendGET();

            return Tools.TryGetResponse<Candles, CandlesTemp>(rc);
        }
        #endregion
    }
}
