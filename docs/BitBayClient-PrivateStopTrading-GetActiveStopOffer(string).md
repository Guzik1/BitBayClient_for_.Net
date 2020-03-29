#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PrivateStopTrading](./BitBayClient-PrivateStopTrading.md 'BitBayClient.PrivateStopTrading')
## PrivateStopTrading.GetActiveStopOffer(string) Method
Get active stop offer for specif market.  
```csharp
public System.Collections.Generic.List<BitBayClient.ResponseModel.ActiveStopOffer> GetActiveStopOffer(string currencyPair);
```
#### Parameters
<a name='BitBayClient-PrivateStopTrading-GetActiveStopOffer(string)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code.  
  
#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ActiveStopOffer](./BitBayClient-ResponseModel-ActiveStopOffer.md 'BitBayClient.ResponseModel.ActiveStopOffer')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
List of active stop offers.  
