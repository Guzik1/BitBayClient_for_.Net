#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[Wallet](./BitBayClient-Wallet.md 'BitBayClient.Wallet')
## Wallet.InternalTransfer(string, string, string, decimal) Method
Internal transfer funds between two wallet. For use, must authorize User  
```csharp
public BitBayClient.ResponseModel.InternalTransfer InternalTransfer(string sourceId, string destinationId, string currencyCode, decimal funds);
```
#### Parameters
<a name='BitBayClient-Wallet-InternalTransfer(string_string_string_decimal)-sourceId'></a>
`sourceId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Wallet source UUID identificator.  
  
<a name='BitBayClient-Wallet-InternalTransfer(string_string_string_decimal)-destinationId'></a>
`destinationId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Wallet destination UUID identificator.  
  
<a name='BitBayClient-Wallet-InternalTransfer(string_string_string_decimal)-currencyCode'></a>
`currencyCode` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency market code.  
  
<a name='BitBayClient-Wallet-InternalTransfer(string_string_string_decimal)-funds'></a>
`funds` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
Amount of funds to transfer.  
  
#### Returns
[InternalTransfer](./BitBayClient-ResponseModel-InternalTransfer.md 'BitBayClient.ResponseModel.InternalTransfer')  
Transfer data, confirmation.  
