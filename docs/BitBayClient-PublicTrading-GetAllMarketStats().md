#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PublicTrading](./BitBayClient-PublicTrading.md 'BitBayClient.PublicTrading')
## PublicTrading.GetAllMarketStats() Method
Get 24 hours market stats for all market on stock exchange.  
```csharp
public System.Collections.Generic.Dictionary<string,BitBayClient.ResponseModel.Stats> GetAllMarketStats();
```
#### Returns
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Stats](./BitBayClient-ResponseModel-Stats.md 'BitBayClient.ResponseModel.Stats')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')  
Dictionary where key is currency pair code, value is stats for key market.  
