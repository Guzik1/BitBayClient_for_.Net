using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient
{
    public enum ErrorMessage
    {
        // General
        PERMISSIONS_NOT_SUFFICIENT,
        INVALID_HASH_SIGNATURE,
        RESPONSE_TIMEOUT,
        TIMEOUT,
        ACTION_BLOCKED,
        ACTION_LIMIT_EXCEEDED,   // Wait one minut to send next query
        UNDER_MAINTENANCE,

        // Standard errors
        MARKET_NOT_RECOGNIZED,
        TICKER_NOT_FOUND,
        NOT_RECOGNIZED_OFFER_TYPE,
        FUNDS_NOT_SUFFICIENT,
        OFFER_FUNDS_NOT_EXCEEDING_MINIMUMS,
        OFFER_FUNDS_SCALE_ISSUE,
        OFFER_COULD_NOT_BE_FILLED,
        OFFER_WOULD_HAVE_BEEN_PARTIALLY_FILLED,
        FILL_OR_KILL_COMBINED_WITH_POST_ONLY,
        INVALID_RESOLUTION,
        OFFER_NOT_FOUND,
        SECONDARY_AMOUNTONLY,
        ALLOWED_WITH_MARKET_OFFER,
        SELF_TRADING,
        PRICE_PRECISION_INVALID,
        USER_OFFER_COUNT_LIMIT_EXCEEDED,

        // Incorrectly constructed query errors
        INVALID_REQUEST,
        MALFORMED_REQUEST,
        MARKET_CODE_CANNOT_BE_EMPTY,

        // Overloading trading errors
        CONFIG_LOAD_TIMEOUT,
        SYSTEM_TIMEOUT,
        CORE_OVERFLOW,
        SYSTEM_OVERLOADED,

        // System errors
        UNKNOWN_ERROR,
        CONFIG_NOT_FOUND,
        NOT_SUPPORTED_RESULT,
        CANNOT_GET_REQUIRED_BALANCE,
        STATS_COULD_NOT_BE_LOADED,
        BALANCE_NOT_FOUND_OR_INCOMPATIBLE,
        BALANCE_NOT_FOUND,

        // Trading stop errors
        INVALID_STOP_RATE,
        INVALID_STOP_OFFER_ID,
        // OFFER_COULD_NOT_BE_FILLED

        //other
        INVALID_CANDLE_RANGE
    }

    public static class ErrorMessageExtension
    {
        public static ErrorMessage Parse(string name)
        {
            return (ErrorMessage)Enum.Parse(typeof(ErrorMessage), name);
        }

        public static bool TryParse(string name, ref ErrorMessage message)
        {
            try
            {
                message = (ErrorMessage)Enum.Parse(typeof(ErrorMessage), name);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
