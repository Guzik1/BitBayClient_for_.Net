#### [BitBayClient](./index.md 'index')
### [BitBayClient.RequestModel](./BitBayClient-RequestModel.md 'BitBayClient.RequestModel').[NewStopOfferRequest](./BitBayClient-RequestModel-NewStopOfferRequest.md 'BitBayClient.RequestModel.NewStopOfferRequest')
## NewStopOfferRequest.SetStopLimitOffer(string, decimal, decimal, decimal) Method
Set stop limit offer temple.  
```csharp
public void SetStopLimitOffer(string offerType, decimal amount, decimal stopRate, decimal rate);
```
#### Parameters
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopLimitOffer(string_decimal_decimal_decimal)-offerType'></a>
`offerType` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Offer type string: BUY/SELL.  
  
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopLimitOffer(string_decimal_decimal_decimal)-amount'></a>
`amount` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Amount of currencies.  
  
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopLimitOffer(string_decimal_decimal_decimal)-stopRate'></a>
`stopRate` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Stop rate, when offer will be added to orderbook.  
  
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopLimitOffer(string_decimal_decimal_decimal)-rate'></a>
`rate` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Offer rate.  
  
