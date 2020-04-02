#### [BitBayClient](./index.md 'index')
### [BitBayClient.RequestModel](./BitBayClient-RequestModel.md 'BitBayClient.RequestModel').[NewStopOfferRequest](./BitBayClient-RequestModel-NewStopOfferRequest.md 'BitBayClient.RequestModel.NewStopOfferRequest')
## NewStopOfferRequest.SetStopLimitSpecifyOffer(string, decimal, decimal, decimal, BitBayClient.RequestModel.Balances) Method
Set stop limit offer with custo balances identificators.  
```csharp
public void SetStopLimitSpecifyOffer(string offerType, decimal amount, decimal stopRate, decimal rate, BitBayClient.RequestModel.Balances balances);
```
#### Parameters
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopLimitSpecifyOffer(string_decimal_decimal_decimal_BitBayClient-RequestModel-Balances)-offerType'></a>
`offerType` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Offer type string: BUY/SELL.  
  
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopLimitSpecifyOffer(string_decimal_decimal_decimal_BitBayClient-RequestModel-Balances)-amount'></a>
`amount` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Amount of currencies.  
  
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopLimitSpecifyOffer(string_decimal_decimal_decimal_BitBayClient-RequestModel-Balances)-stopRate'></a>
`stopRate` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Stop rate, when offer will be added to orderbook.  
  
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopLimitSpecifyOffer(string_decimal_decimal_decimal_BitBayClient-RequestModel-Balances)-rate'></a>
`rate` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Offer rate.  
  
<a name='BitBayClient-RequestModel-NewStopOfferRequest-SetStopLimitSpecifyOffer(string_decimal_decimal_decimal_BitBayClient-RequestModel-Balances)-balances'></a>
`balances` [Balances](./BitBayClient-RequestModel-Balances.md 'BitBayClient.RequestModel.Balances')  
Balances object (first and second wallet).  
  
