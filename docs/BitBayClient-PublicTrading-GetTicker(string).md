#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PublicTrading](./BitBayClient-PublicTrading.md 'BitBayClient.PublicTrading')
## PublicTrading.GetTicker(string) Method
Get ticker for selected market.  
```csharp
public BitBayClient.ResponseModel.Ticker GetTicker(string currencyPair);
```
#### Parameters
<a name='BitBayClient-PublicTrading-GetTicker(string)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair with dash, example BTC-USD  
  
#### Returns
[Ticker](./BitBayClient-ResponseModel-Ticker.md 'BitBayClient.ResponseModel.Ticker')  
Ticker for selected market. Return "ticker" atribut from api response.  
