#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[Wallet](./BitBayClient-Wallet.md 'BitBayClient.Wallet')
## Wallet.CreateNewWallet(string, string, BitBayClient.WalletType) Method
Create new wallet on user account. For use, must authorize User  
```csharp
public BitBayClient.ResponseModel.WalletItem CreateNewWallet(string currencyCode, string name, BitBayClient.WalletType walletType);
```
#### Parameters
<a name='BitBayClient-Wallet-CreateNewWallet(string_string_BitBayClient-WalletType)-currencyCode'></a>
`currencyCode` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency code.  
  
<a name='BitBayClient-Wallet-CreateNewWallet(string_string_BitBayClient-WalletType)-name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Wallet name  
  
<a name='BitBayClient-Wallet-CreateNewWallet(string_string_BitBayClient-WalletType)-walletType'></a>
`walletType` [WalletType](./BitBayClient-WalletType.md 'BitBayClient.WalletType')  
Wallet type: crypto/fiat.  
  
#### Returns
[WalletItem](./BitBayClient-ResponseModel-WalletItem.md 'BitBayClient.ResponseModel.WalletItem')  
Created wallet data.  
