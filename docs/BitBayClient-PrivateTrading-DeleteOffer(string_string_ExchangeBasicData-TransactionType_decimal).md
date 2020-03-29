#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PrivateTrading](./BitBayClient-PrivateTrading.md 'BitBayClient.PrivateTrading')
## PrivateTrading.DeleteOffer(string, string, ExchangeBasicData.TransactionType, decimal) Method
Delete offer from market. For use must autorize User.  
```csharp
public bool DeleteOffer(string currencyPair, string offerId, ExchangeBasicData.TransactionType offerType, decimal offerRate);
```
#### Parameters
<a name='BitBayClient-PrivateTrading-DeleteOffer(string_string_ExchangeBasicData-TransactionType_decimal)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code.  
  
<a name='BitBayClient-PrivateTrading-DeleteOffer(string_string_ExchangeBasicData-TransactionType_decimal)-offerId'></a>
`offerId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Offer UUID identificator, geting on offer add.  
  
<a name='BitBayClient-PrivateTrading-DeleteOffer(string_string_ExchangeBasicData-TransactionType_decimal)-offerType'></a>
`offerType` [ExchangeBasicData.TransactionType](https://docs.microsoft.com/en-us/dotnet/api/ExchangeBasicData.TransactionType 'ExchangeBasicData.TransactionType')  
Offer type: buy or sell.  
  
<a name='BitBayClient-PrivateTrading-DeleteOffer(string_string_ExchangeBasicData-TransactionType_decimal)-offerRate'></a>
`offerRate` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Offer rate.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if offer was deleted succesfull or false else.  
