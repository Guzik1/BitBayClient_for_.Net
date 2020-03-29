#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PublicTrading](./BitBayClient-PublicTrading.md 'BitBayClient.PublicTrading')
## PublicTrading.GetAllTicker() Method
Get ticker for all market on stock exchange.  
```csharp
public System.Collections.Generic.Dictionary<string,BitBayClient.ResponseModel.Ticker> GetAllTicker();
```
#### Returns
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Ticker](./BitBayClient-ResponseModel-Ticker.md 'BitBayClient.ResponseModel.Ticker')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')  
Dictionary where key is market code, value is ticker for this market code. Return "ticker" atribut from api response.  
