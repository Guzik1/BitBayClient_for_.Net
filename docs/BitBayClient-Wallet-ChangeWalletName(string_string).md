#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[Wallet](./BitBayClient-Wallet.md 'BitBayClient.Wallet')
## Wallet.ChangeWalletName(string, string) Method
Change wallet name on user account. For use, must authorize User  
```csharp
public bool ChangeWalletName(string identificator, string newName);
```
#### Parameters
<a name='BitBayClient-Wallet-ChangeWalletName(string_string)-identificator'></a>
`identificator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Wallet UUID identificator.  
  
<a name='BitBayClient-Wallet-ChangeWalletName(string_string)-newName'></a>
`newName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
New wallet name.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if wallet name was changed succesfull or false else.  
