namespace BitBayClient
{
    /// <summary>
    /// Error message enum, represent errors was return from serwer, which response status is fail.
    /// </summary>
    public enum ErrorMessage
    {
        // General errors
        /// <summary>Permisions for public api key, are not sufficient to execute action.</summary>
        PERMISSIONS_NOT_SUFFICIENT,
        /// <summary>The hash query signature (Autorization hash) is invalid.</summary>
        INVALID_HASH_SIGNATURE,
        /// <summary>The response time has been exceeded.</summary>
        RESPONSE_TIMEOUT,
        /// <summary>Invalid method reference: unsupported parameters, unsupported query type or error in reference to method name.</summary>
        TIMEOUT,
        /// <summary>The action is blocked on the user's account.</summary>
        ACTION_BLOCKED,
        /// <summary>The action call limit has been user, wait one full minut before next call to serwer.</summary>
        ACTION_LIMIT_EXCEEDED,   // Wait one minut to send next query
        /// <summary>Maintenance work or updates are curently underway.</summary>
        UNDER_MAINTENANCE,

        // Standard errors
        /// <summary>Market code was not recognized.</summary>
        MARKET_NOT_RECOGNIZED,
        /// <summary>Ticker for market was not found.</summary>
        TICKER_NOT_FOUND,
        /// <summary>Not recognized offer type, incorrect name.</summary>
        NOT_RECOGNIZED_OFFER_TYPE,
        /// <summary>Funds on account's are not sufficient to complete the offer.</summary>
        FUNDS_NOT_SUFFICIENT,
        /// <summary>The offer value us less than acceptable minimum value from market ticker.</summary>
        OFFER_FUNDS_NOT_EXCEEDING_MINIMUMS,
        /// <summary>The numerical value provided in the query doesn't match the number of decimal places for the currency.</summary>
        OFFER_FUNDS_SCALE_ISSUE,
        /// <summary>The offer cannot be completed in full, applies to Fill or kill method. There aren't enough offers in the orderbook.</summary>
        OFFER_COULD_NOT_BE_FILLED,
        /// <summary>The offer can be realized only in part, applies to Fill or kill method.</summary>
        OFFER_WOULD_HAVE_BEEN_PARTIALLY_FILLED,
        /// <summary>Used type "fill or kill" from "post only", these parameters cannot be sent together.</summary>
        FILL_OR_KILL_COMBINED_WITH_POST_ONLY,
        /// <summary>Incorrect resolution parameter value for historic candles.</summary>
        INVALID_RESOLUTION,
        /// <summary>The offer was not found (if offer canceled request).</summary>
        OFFER_NOT_FOUND,
        /// <summary>For maker offer.</summary>
        SECONDARY_AMOUNTONLY,
        /// <summary>Allowed with market offer.</summary>
        ALLOWED_WITH_MARKET_OFFER,
        /// <summary>The user has opposite offers in a market.</summary>
        SELF_TRADING,
        /// <summary>Incorrect price precision.</summary>
        PRICE_PRECISION_INVALID,
        /// <summary>The limit of offers placed on the market has been exhausted (delete one other offer).</summary>
        USER_OFFER_COUNT_LIMIT_EXCEEDED,
        /// <summary>The selected market is turned off.</summary>
        MARKET_DISABLED,

        // Incorrectly constructed query errors
        /// <summary>The query was constructed incorrectly.</summary>
        INVALID_REQUEST,
        /// <summary>The JOSN object sent in the query is corrupted.</summary>
        MALFORMED_REQUEST,
        /// <summary>No market code provided.</summary>
        MARKET_CODE_CANNOT_BE_EMPTY,

        // Overloading trading errors
        /// <summary>Can not load market configuration.</summary>
        CONFIG_LOAD_TIMEOUT,
        /// <summary>System response time exceeded.</summary>
        SYSTEM_TIMEOUT,
        /// <summary>The trading system has been overloaded.</summary>
        CORE_OVERFLOW,
        /// <summary>The stock exchange system is overloaded.</summary>
        SYSTEM_OVERLOADED,

        // System errors
        /// <summary>System unknown error has occurred.</summary>
        UNKNOWN_ERROR,
        /// <summary>User market configuration not found.</summary>
        CONFIG_NOT_FOUND,
        /// <summary>The response from the query module is not correct.</summary>
        NOT_SUPPORTED_RESULT,
        /// <summary>Unable to access user wallet.</summary>
        CANNOT_GET_REQUIRED_BALANCE,
        /// <summary>Makret statistic cannot be loaded.</summary>
        STATS_COULD_NOT_BE_LOADED,
        /// <summary>Balance wallet not found or unsupported.</summary>
        BALANCE_NOT_FOUND_OR_INCOMPATIBLE,
        /// <summary>Balance wallet not found.</summary>
        BALANCE_NOT_FOUND,

        // Trading stop errors
        /// <summary>StopRate value is invalid - the offer can be realize immedietly. To allow immediate execution set the "ignoreInvalidStopRate" parameter to true.</summary>
        INVALID_STOP_RATE,
        /// <summary>Invalid ID for stop offer - the offer with this id does not exist.</summary>
        INVALID_STOP_OFFER_ID,
        //OFFER_COULD_NOT_BE_FILLED
    }
}
