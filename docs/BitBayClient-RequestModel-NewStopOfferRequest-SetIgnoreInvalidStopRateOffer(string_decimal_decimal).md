#### [BitBayClient](./index.md 'index')
### [BitBayClient.RequestModel](./BitBayClient-RequestModel.md 'BitBayClient.RequestModel').[NewStopOfferRequest](./BitBayClient-RequestModel-NewStopOfferRequest.md 'BitBayClient.RequestModel.NewStopOfferRequest')
## NewStopOfferRequest.SetIgnoreInvalidStopRateOffer(string, decimal, decimal) Method
Set stop market offer, with ignoring invalid stop rate (the offer can be realized immediately).  
```csharp
public void SetIgnoreInvalidStopRateOffer(string offerType, decimal amount, decimal stopRate);
```
#### Parameters
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetIgnoreInvalidStopRateOffer(string_decimal_decimal)-offerType'></a>
`offerType` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Offer type string: BUY/SELL.  
  
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetIgnoreInvalidStopRateOffer(string_decimal_decimal)-amount'></a>
`amount` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Amount of currencies.  
  
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetIgnoreInvalidStopRateOffer(string_decimal_decimal)-stopRate'></a>
`stopRate` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Stop rate, when offer will be added to orderbook.  
  
