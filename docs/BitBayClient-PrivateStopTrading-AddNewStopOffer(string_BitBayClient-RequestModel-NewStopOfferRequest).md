#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PrivateStopTrading](./BitBayClient-PrivateStopTrading.md 'BitBayClient.PrivateStopTrading')
## PrivateStopTrading.AddNewStopOffer(string, BitBayClient.RequestModel.NewStopOfferRequest) Method
Add new stop offer to user account. For use, must authorize User.  
```csharp
public string AddNewStopOffer(string currencyPair, BitBayClient.RequestModel.NewStopOfferRequest body);
```
#### Parameters
<a name='BitBayClient-PrivateStopTrading-AddNewStopOffer(string_BitBayClient-RequestModel-NewStopOfferRequest)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code.  
  
<a name='BitBayClient-PrivateStopTrading-AddNewStopOffer(string_BitBayClient-RequestModel-NewStopOfferRequest)-body'></a>
`body` [NewStopOfferRequest](./BitBayClient-RequestModel-NewStopOfferRequest.md 'BitBayClient.RequestModel.NewStopOfferRequest')  
New offer body.  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Offer UUID identificator.  
