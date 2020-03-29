#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PrivateTrading](./BitBayClient-PrivateTrading.md 'BitBayClient.PrivateTrading')
## PrivateTrading.AddNewOffer(string, BitBayClient.RequestModel.NewOfferRequest) Method
Add new offer, using NewOfferRequest body and sepcif currency pair code. For use must autorize User.  
```csharp
public BitBayClient.ResponseModel.NewOffer AddNewOffer(string currencyPair, BitBayClient.RequestModel.NewOfferRequest body);
```
#### Parameters
<a name='BitBayClient-PrivateTrading-AddNewOffer(string_BitBayClient-RequestModel-NewOfferRequest)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code string.  
  
<a name='BitBayClient-PrivateTrading-AddNewOffer(string_BitBayClient-RequestModel-NewOfferRequest)-body'></a>
`body` [NewOfferRequest](./BitBayClient-RequestModel-NewOfferRequest.md 'BitBayClient.RequestModel.NewOfferRequest')  
New offer body request.  
  
#### Returns
[NewOffer](./BitBayClient-ResponseModel-NewOffer.md 'BitBayClient.ResponseModel.NewOffer')  
New offer response.  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Throw on event, the body params was null.  
