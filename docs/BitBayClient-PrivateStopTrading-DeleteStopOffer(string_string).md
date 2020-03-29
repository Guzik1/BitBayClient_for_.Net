#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PrivateStopTrading](./BitBayClient-PrivateStopTrading.md 'BitBayClient.PrivateStopTrading')
## PrivateStopTrading.DeleteStopOffer(string, string) Method
Delete specif offer UUID on specif currency pair.  
```csharp
public bool DeleteStopOffer(string currencyPair, string offerId);
```
#### Parameters
<a name='BitBayClient-PrivateStopTrading-DeleteStopOffer(string_string)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code.  
  
<a name='BitBayClient-PrivateStopTrading-DeleteStopOffer(string_string)-offerId'></a>
`offerId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Offer UUID identificator.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Return true if delete stop offer successful or return false else.  
