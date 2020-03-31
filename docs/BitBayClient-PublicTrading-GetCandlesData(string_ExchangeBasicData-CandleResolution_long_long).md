#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PublicTrading](./BitBayClient-PublicTrading.md 'BitBayClient.PublicTrading')
## PublicTrading.GetCandlesData(string, ExchangeBasicData.CandleResolution, long, long) Method
Get all candles with specif resolution for selected currencyPair, start result "fromTimeUnix" and end in "toTimeUnix".  
For get one candle time from and time to must be the same.  
```csharp
public BitBayClient.ResponseModel.Candles GetCandlesData(string currencyPair, ExchangeBasicData.CandleResolution resolution, long fromTimeUnix, long toTimeUnix);
```
#### Parameters
<a name='BitBayClient-PublicTrading-GetCandlesData(string_ExchangeBasicData-CandleResolution_long_long)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code string, example BTC-USD.  
  
<a name='BitBayClient-PublicTrading-GetCandlesData(string_ExchangeBasicData-CandleResolution_long_long)-resolution'></a>
`resolution` [ExchangeBasicData.CandleResolution](https://docs.microsoft.com/en-us/dotnet/api/ExchangeBasicData.CandleResolution 'ExchangeBasicData.CandleResolution')  
Select candle resolution.  
  
<a name='BitBayClient-PublicTrading-GetCandlesData(string_ExchangeBasicData-CandleResolution_long_long)-fromTimeUnix'></a>
`fromTimeUnix` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
Unix timestamp from start geting candles.  
  
<a name='BitBayClient-PublicTrading-GetCandlesData(string_ExchangeBasicData-CandleResolution_long_long)-toTimeUnix'></a>
`toTimeUnix` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
Unix timestamp to end geting candles.  
  
#### Returns
[Candles](./BitBayClient-ResponseModel-Candles.md 'BitBayClient.ResponseModel.Candles')  
Candles data object.  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Throw if "fromTimeUnix" is great than "toTimeUnix". From time must be before to time.  
