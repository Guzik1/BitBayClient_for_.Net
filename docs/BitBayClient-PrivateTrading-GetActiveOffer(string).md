#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PrivateTrading](./BitBayClient-PrivateTrading.md 'BitBayClient.PrivateTrading')
## PrivateTrading.GetActiveOffer(string) Method
Get all active offer from specif market. For use must autorize User.  
```csharp
public System.Collections.Generic.List<BitBayClient.ResponseModel.ActiveOffer> GetActiveOffer(string currencyPair);
```
#### Parameters
<a name='BitBayClient-PrivateTrading-GetActiveOffer(string)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code.  
  
#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ActiveOffer](./BitBayClient-ResponseModel-ActiveOffer.md 'BitBayClient.ResponseModel.ActiveOffer')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
List of all active offers on currencyPair market.  
