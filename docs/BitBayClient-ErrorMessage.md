#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient')
## ErrorMessage Enum
Error message enum, represent errors was return from serwer, which response status is fail.  
```csharp
public enum ErrorMessage
```
### Fields
<a name='BitBayClient-ErrorMessage-PERMISSIONS_NOT_SUFFICIENT'></a>
`PERMISSIONS_NOT_SUFFICIENT` 0  
Permisions for public api key, are not sufficient to execute action.  
  
<a name='BitBayClient-ErrorMessage-INVALID_HASH_SIGNATURE'></a>
`INVALID_HASH_SIGNATURE` 1  
The hash query signature (Autorization hash) is invalid.  
  
<a name='BitBayClient-ErrorMessage-RESPONSE_TIMEOUT'></a>
`RESPONSE_TIMEOUT` 2  
The response time has been exceeded.  
  
<a name='BitBayClient-ErrorMessage-TIMEOUT'></a>
`TIMEOUT` 3  
Invalid method reference: unsupported parameters, unsupported query type or error in reference to method name.  
  
<a name='BitBayClient-ErrorMessage-ACTION_BLOCKED'></a>
`ACTION_BLOCKED` 4  
The action is blocked on the user's account.  
  
<a name='BitBayClient-ErrorMessage-ACTION_LIMIT_EXCEEDED'></a>
`ACTION_LIMIT_EXCEEDED` 5  
The action call limit has been user, wait one full minut before next call to serwer.  
  
<a name='BitBayClient-ErrorMessage-UNDER_MAINTENANCE'></a>
`UNDER_MAINTENANCE` 6  
Maintenance work or updates are curently underway.  
  
<a name='BitBayClient-ErrorMessage-MARKET_NOT_RECOGNIZED'></a>
`MARKET_NOT_RECOGNIZED` 7  
Market code was not recognized.  
  
<a name='BitBayClient-ErrorMessage-TICKER_NOT_FOUND'></a>
`TICKER_NOT_FOUND` 8  
Ticker for market was not found.  
  
<a name='BitBayClient-ErrorMessage-NOT_RECOGNIZED_OFFER_TYPE'></a>
`NOT_RECOGNIZED_OFFER_TYPE` 9  
Not recognized offer type, incorrect name.  
  
<a name='BitBayClient-ErrorMessage-FUNDS_NOT_SUFFICIENT'></a>
`FUNDS_NOT_SUFFICIENT` 10  
Funds on account's are not sufficient to complete the offer.  
  
<a name='BitBayClient-ErrorMessage-OFFER_FUNDS_NOT_EXCEEDING_MINIMUMS'></a>
`OFFER_FUNDS_NOT_EXCEEDING_MINIMUMS` 11  
The offer value us less than acceptable minimum value from market ticker.  
  
<a name='BitBayClient-ErrorMessage-OFFER_FUNDS_SCALE_ISSUE'></a>
`OFFER_FUNDS_SCALE_ISSUE` 12  
The numerical value provided in the query doesn't match the number of decimal places for the currency.  
  
<a name='BitBayClient-ErrorMessage-OFFER_COULD_NOT_BE_FILLED'></a>
`OFFER_COULD_NOT_BE_FILLED` 13  
The offer cannot be completed in full, applies to Fill or kill method. There aren't enough offers in the orderbook.  
  
<a name='BitBayClient-ErrorMessage-OFFER_WOULD_HAVE_BEEN_PARTIALLY_FILLED'></a>
`OFFER_WOULD_HAVE_BEEN_PARTIALLY_FILLED` 14  
The offer can be realized only in part, applies to Fill or kill method.  
  
<a name='BitBayClient-ErrorMessage-FILL_OR_KILL_COMBINED_WITH_POST_ONLY'></a>
`FILL_OR_KILL_COMBINED_WITH_POST_ONLY` 15  
Used type "fill or kill" from "post only", these parameters cannot be sent together.  
  
<a name='BitBayClient-ErrorMessage-INVALID_RESOLUTION'></a>
`INVALID_RESOLUTION` 16  
Incorrect resolution parameter value for historic candles.  
  
<a name='BitBayClient-ErrorMessage-OFFER_NOT_FOUND'></a>
`OFFER_NOT_FOUND` 17  
The offer was not found (if offer canceled request).  
  
<a name='BitBayClient-ErrorMessage-SECONDARY_AMOUNTONLY'></a>
`SECONDARY_AMOUNTONLY` 18  
For maker offer.  
  
<a name='BitBayClient-ErrorMessage-ALLOWED_WITH_MARKET_OFFER'></a>
`ALLOWED_WITH_MARKET_OFFER` 19  
Allowed with market offer.  
  
<a name='BitBayClient-ErrorMessage-SELF_TRADING'></a>
`SELF_TRADING` 20  
The user has opposite offers in a market.  
  
<a name='BitBayClient-ErrorMessage-PRICE_PRECISION_INVALID'></a>
`PRICE_PRECISION_INVALID` 21  
Incorrect price precision.  
  
<a name='BitBayClient-ErrorMessage-USER_OFFER_COUNT_LIMIT_EXCEEDED'></a>
`USER_OFFER_COUNT_LIMIT_EXCEEDED` 22  
The limit of offers placed on the market has been exhausted (delete one other offer).  
  
<a name='BitBayClient-ErrorMessage-MARKET_DISABLED'></a>
`MARKET_DISABLED` 23  
The selected market is turned off.  
  
<a name='BitBayClient-ErrorMessage-INVALID_REQUEST'></a>
`INVALID_REQUEST` 24  
The query was constructed incorrectly.  
  
<a name='BitBayClient-ErrorMessage-MALFORMED_REQUEST'></a>
`MALFORMED_REQUEST` 25  
The JOSN object sent in the query is corrupted.  
  
<a name='BitBayClient-ErrorMessage-MARKET_CODE_CANNOT_BE_EMPTY'></a>
`MARKET_CODE_CANNOT_BE_EMPTY` 26  
No market code provided.  
  
<a name='BitBayClient-ErrorMessage-CONFIG_LOAD_TIMEOUT'></a>
`CONFIG_LOAD_TIMEOUT` 27  
Can not load market configuration.  
  
<a name='BitBayClient-ErrorMessage-SYSTEM_TIMEOUT'></a>
`SYSTEM_TIMEOUT` 28  
System response time exceeded.  
  
<a name='BitBayClient-ErrorMessage-CORE_OVERFLOW'></a>
`CORE_OVERFLOW` 29  
The trading system has been overloaded.  
  
<a name='BitBayClient-ErrorMessage-SYSTEM_OVERLOADED'></a>
`SYSTEM_OVERLOADED` 30  
The stock exchange system is overloaded.  
  
<a name='BitBayClient-ErrorMessage-UNKNOWN_ERROR'></a>
`UNKNOWN_ERROR` 31  
System unknown error has occurred.  
  
<a name='BitBayClient-ErrorMessage-CONFIG_NOT_FOUND'></a>
`CONFIG_NOT_FOUND` 32  
User market configuration not found.  
  
<a name='BitBayClient-ErrorMessage-NOT_SUPPORTED_RESULT'></a>
`NOT_SUPPORTED_RESULT` 33  
The response from the query module is not correct.  
  
<a name='BitBayClient-ErrorMessage-CANNOT_GET_REQUIRED_BALANCE'></a>
`CANNOT_GET_REQUIRED_BALANCE` 34  
Unable to access user wallet.  
  
<a name='BitBayClient-ErrorMessage-STATS_COULD_NOT_BE_LOADED'></a>
`STATS_COULD_NOT_BE_LOADED` 35  
Makret statistic cannot be loaded.  
  
<a name='BitBayClient-ErrorMessage-BALANCE_NOT_FOUND_OR_INCOMPATIBLE'></a>
`BALANCE_NOT_FOUND_OR_INCOMPATIBLE` 36  
Balance wallet not found or unsupported.  
  
<a name='BitBayClient-ErrorMessage-BALANCE_NOT_FOUND'></a>
`BALANCE_NOT_FOUND` 37  
Balance wallet not found.  
  
<a name='BitBayClient-ErrorMessage-INVALID_STOP_RATE'></a>
`INVALID_STOP_RATE` 38  
StopRate value is invalid - the offer can be realize immedietly. To allow immediate execution set the "ignoreInvalidStopRate" parameter to true.  
  
<a name='BitBayClient-ErrorMessage-INVALID_STOP_OFFER_ID'></a>
`INVALID_STOP_OFFER_ID` 39  
Invalid ID for stop offer - the offer with this id does not exist.  
  
