#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PublicTrading](./BitBayClient-PublicTrading.md 'BitBayClient.PublicTrading')
## PublicTrading.GetMarketStats(string) Method
Get 24 hours market stats for selected currency pair.  
```csharp
public BitBayClient.ResponseModel.Stats GetMarketStats(string currencePair);
```
#### Parameters
<a name='BitBayClient-PublicTrading-GetMarketStats(string)-currencePair'></a>
`currencePair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code, example BTC-USD  
  
#### Returns
[Stats](./BitBayClient-ResponseModel-Stats.md 'BitBayClient.ResponseModel.Stats')  
24 hours stats for currency pair. Return "stats" list from response.  
