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
    public partial class BitBayClient
    {
        Config config = new Config();

        #region Ticker
        public Ticker GetTicker(Pair pair)
            => SendGetTicer<Ticker>("/" + pair.ToStringWithDash());

        public AllTickers GetAllTicker()
            => SendGetTicer<AllTickers>("");

        Expected SendGetTicer<Expected>(string url)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "ticker" + url);
            rc.SendGET();

            return TryGetResponse<Expected>(rc);
        }
        #endregion

        #region Market stats
        public Stats GetMarketStats(Pair pair)
            => SendGetMarketStats<Stats, StatTemp>("/" + pair.ToStringWithDash());

        public AllStats GetAllMarketStats()
            => SendGetMarketStats<AllStats, AllStatsTemp>();

        Expected SendGetMarketStats<Expected, Temp>(string url = "")
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "stats" + url);
            rc.SendGET();

            return TryGetResponse<Expected, Temp>(rc);
        }
        #endregion

        #region Orderbook
        public Orderbook GetOrderbook(Pair pair)
        {
            return SendGetOrderBook("orderbook/" + pair.ToStringWithDash());
        }

        public Orderbook GetOrderbook(Pair pair, OrderbookLimits limit)
        {
            return SendGetOrderBook($"orderbook-limited/{ pair.ToStringWithDash() }/{ limit.ToInt() }");
        }

        Orderbook SendGetOrderBook(string url)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + url);
            rc.SendGET();

            return TryGetResponse<Orderbook, OrderbookTemp>(rc);
        }
        #endregion

        #region Last transactions
        public LastTransactions GetLastTransactions(Pair pair)
            => SendLastTransactionsRequest(pair.ToStringWithDash());

        public LastTransactions GetLastTransactions(Pair pair, int limit)
        {
            CheckLimitValue(limit);

            Dictionary<string, string> query = GenerateQuery(limit);

            return SendLastTransactionsRequest(pair.ToStringWithDash(), query);
        }

        public LastTransactions GetLastTransactions(Pair pair, DateTime fromDate)
        {
            fromDate = Date.Truncate(fromDate, TimeSpan.FromSeconds(1));

            Dictionary<string, string> query = GenerateQuery(date: fromDate);

            LastTransactions lt = SendLastTransactionsRequest(pair.ToStringWithDash(), query);
            lt.RequestTime = fromDate;

            return lt;
        }

        public LastTransactions GetLastTransactions(Pair pair, int limit, DateTime fromDate)
        {
            CheckLimitValue(limit);

            fromDate = Date.Truncate(fromDate, TimeSpan.FromSeconds(1));

            Dictionary<string, string> query = GenerateQuery(limit, fromDate);

            LastTransactions lt = SendLastTransactionsRequest(pair.ToStringWithDash(), query);
            lt.RequestTime = fromDate;

            return lt;
        }

        void CheckLimitValue(int limit)
        {
            if (limit > 300)
                throw new ArgumentException("Limit must be less or equal 300.");
        }

        Dictionary<string, string> GenerateQuery(int limit = 0, DateTime date = default)
        {
            Dictionary<string, string> query = new Dictionary<string, string>();

            if (limit != 0)
                query.Add("limit", limit.ToString());

            if (date != default)
            {
                long unixDate = Date.Convert(date);
                query.Add("from", unixDate.ToString());
            }

            return query;
        }

        LastTransactions SendLastTransactionsRequest(string path, Dictionary<string, string> query = null)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "transactions/" + path);

            if (query != null)
                rc.AddQuery(query);

            rc.SendGET();

            return TryGetResponse<LastTransactions, LastTransactionsTemp>(rc);
        }
        #endregion

        #region Candle
        public CandlesData GetCandleChartData(Pair pair, CandleResolution resolution)
            => SendCandleChartDataRequest(pair.ToStringWithDash() + "/" + resolution.GetSecond());

        public CandlesData GetCandleChartData(Pair pair, CandleResolution resolution, DateTime from, DateTime to)
        {
            if (from > to)
                throw new ArgumentException("Date to must be leter(not equal) than date from!");

            Dictionary<string, string> query = CreateCandleQuery(from, to, resolution.GetSecond());

            return SendCandleChartDataRequest(pair.ToStringWithDash() + "/" + resolution.GetSecond(), query);
        }

        Dictionary<string, string> CreateCandleQuery(DateTime from, DateTime to, int resolutionSecond)
        {
            Dictionary<string, string> query = new Dictionary<string, string>();

            from = Date.Truncate(from, new TimeSpan(0, 0, resolutionSecond));
            to = Date.Truncate(to, new TimeSpan(0, 0, resolutionSecond));

            long fromUnix = Date.Convert(from);
            long toUnix = Date.Convert(to);

            query.Add("from", fromUnix.ToString());
            query.Add("to", toUnix.ToString());

            return query;
        }

        CandlesData SendCandleChartDataRequest(string path, Dictionary<string, string> query = null)
        {
            RestClient rc = new RestClient(config.ApiTradingUrl + "candle/history/" + path);

            if (query != null)
                rc.AddQuery(query);

            rc.SendGET();

            return TryGetResponse<CandlesData>(rc);
        }
        #endregion
    }
}
