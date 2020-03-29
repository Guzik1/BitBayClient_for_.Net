#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PrivateTrading](./BitBayClient-PrivateTrading.md 'BitBayClient.PrivateTrading')
## PrivateTrading.GetCommissionsAndConfiguration(string) Method
Get commisions and configuration assinged to the account. For use must autorize User.  
```csharp
public BitBayClient.ResponseModel.CommissionAndConfig GetCommissionsAndConfiguration(string currencyPair);
```
#### Parameters
<a name='BitBayClient-PrivateTrading-GetCommissionsAndConfiguration(string)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code.  
  
#### Returns
[CommissionAndConfig](./BitBayClient-ResponseModel-CommissionAndConfig.md 'BitBayClient.ResponseModel.CommissionAndConfig')  
Commision and configuration data object.  
