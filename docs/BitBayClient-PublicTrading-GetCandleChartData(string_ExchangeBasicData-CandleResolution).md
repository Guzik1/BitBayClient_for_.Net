#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PublicTrading](./BitBayClient-PublicTrading.md 'BitBayClient.PublicTrading')
## PublicTrading.GetCandleChartData(string, ExchangeBasicData.CandleResolution) Method
Get all candles with specif resolution for selected currencyPair.  
```csharp
public BitBayClient.ResponseModel.Candles GetCandleChartData(string currencyPair, ExchangeBasicData.CandleResolution resolution);
```
#### Parameters
<a name='BitBayClient-PublicTrading-GetCandleChartData(string_ExchangeBasicData-CandleResolution)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code string.  
  
<a name='BitBayClient-PublicTrading-GetCandleChartData(string_ExchangeBasicData-CandleResolution)-resolution'></a>
`resolution` [ExchangeBasicData.CandleResolution](https://docs.microsoft.com/en-us/dotnet/api/ExchangeBasicData.CandleResolution 'ExchangeBasicData.CandleResolution')  
Select candle resolution.  
  
#### Returns
[Candles](./BitBayClient-ResponseModel-Candles.md 'BitBayClient.ResponseModel.Candles')  
Candles data object.  
