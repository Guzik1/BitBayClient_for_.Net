using BitBayClient.RequestModel;
using BitBayClient.ResponseModel;
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
        public Ticker GetTicker(string currencyPair)
            => SendGetTicer<Ticker>("/" + currencyPair);

        public AllTickers GetAllTicker()
            => SendGetTicer<AllTickers>("");

        Expected SendGetTicer<Expected>(string url)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "ticker" + url);
            rc.SendGET();

            return Tools.TryGetResponse<Expected>(rc);
        }
        #endregion

        #region Market stats
        public Stats GetMarketStats(string currencePair)
            => SendGetMarketStats<Stats>("/" + currencePair);

        public AllStats GetAllMarketStats()
            => SendGetMarketStats<AllStats>();

        Expected SendGetMarketStats<Expected>(string url = "")
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "stats" + url);
            rc.SendGET();

            return Tools.TryGetResponse<Expected>(rc);
        }
        #endregion

        #region Orderbook
        public Orderbook GetOrderbook(string currencyPair)
        {
            return SendGetOrderBook("orderbook/" + currencyPair);
        }

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
        public LastTransactions GetLastTransactions(string currencyPair)
            => SendLastTransactionsRequest(currencyPair);

        public LastTransactions GetLastTransactions(string currencyPair, int limit)
        {
            CheckLimitValue(limit);

            Dictionary<string, string> query = GenerateQuery(limit);

            return SendLastTransactionsRequest(currencyPair, query);
        }

        public LastTransactions GetLastTransactions(string currencyPair, long fromTimeUnix)
        {
            Dictionary<string, string> query = GenerateQuery(timeUnix: fromTimeUnix);

            return SendLastTransactionsRequest(currencyPair, query);
        }

        public LastTransactions GetLastTransactions(string currencyPair, int limit, long fromTimeUnix)
        {
            CheckLimitValue(limit);

            Dictionary<string, string> query = GenerateQuery(limit, fromTimeUnix);

            return SendLastTransactionsRequest(currencyPair, query);
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
        public Candles GetCandleChartData(string currencyPair, CandleResolution resolution)
            => SendCandleChartDataRequest(currencyPair + "/" + resolution.GetSecond());

        public Candles GetCandleChartData(string currencyPair, CandleResolution resolution, long fromTimeUnix, long toTimeUnix)
        {
            if (fromTimeUnix > toTimeUnix)
                throw new ArgumentException("Date to must be leter(not equal) than date from!");

            Dictionary<string, string> query = CreateCandleQuery(fromTimeUnix, toTimeUnix, resolution.GetSecond());

            return SendCandleChartDataRequest(currencyPair + "/" + resolution.GetSecond(), query);
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

            return Tools.TryGetResponse<Candles>(rc);
        }
        #endregion
    }
}
