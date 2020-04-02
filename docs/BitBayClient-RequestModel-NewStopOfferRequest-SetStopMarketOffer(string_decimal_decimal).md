#### [BitBayClient](./index.md 'index')
### [BitBayClient.RequestModel](./BitBayClient-RequestModel.md 'BitBayClient.RequestModel').[NewStopOfferRequest](./BitBayClient-RequestModel-NewStopOfferRequest.md 'BitBayClient.RequestModel.NewStopOfferRequest')
## NewStopOfferRequest.SetStopMarketOffer(string, decimal, decimal) Method
Set quick sell/buy offer, activated when stop rate will be achieved.  
```csharp
public void SetStopMarketOffer(string offerType, decimal amount, decimal stopRate);
```
#### Parameters
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopMarketOffer(string_decimal_decimal)-offerType'></a>
`offerType` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Offer type string: BUY/SELL.  
  
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopMarketOffer(string_decimal_decimal)-amount'></a>
`amount` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Amount of currencies.  
  
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopMarketOffer(string_decimal_decimal)-stopRate'></a>
`stopRate` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Stop rate, when offer will be added to orderbook.  
  
