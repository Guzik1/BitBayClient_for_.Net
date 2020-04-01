#### [BitBayClient](./index.md 'index')
### [BitBayClient.RequestModel](./BitBayClient-RequestModel.md 'BitBayClient.RequestModel').[NewOfferRequest](./BitBayClient-RequestModel-NewOfferRequest.md 'BitBayClient.RequestModel.NewOfferRequest')
## NewOfferRequest.SetLimitOffer(string, decimal, decimal) Method
Set STANDARD offer type on exchange (default on exchange view). Set const rate and amount of currencies.  
```csharp
public void SetLimitOffer(string offerType, decimal amount, decimal rate);
```
#### Parameters
<a name='BitBayClient-RequestModel-NewOfferRequest-SetLimitOffer(string_decimal_decimal)-offerType'></a>
`offerType` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String offer type: BUY/SELL  
  
<a name='BitBayClient-RequestModel-NewOfferRequest-SetLimitOffer(string_decimal_decimal)-amount'></a>
`amount` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Amount of currencies  
  
<a name='BitBayClient-RequestModel-NewOfferRequest-SetLimitOffer(string_decimal_decimal)-rate'></a>
`rate` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Offer rate  
  
