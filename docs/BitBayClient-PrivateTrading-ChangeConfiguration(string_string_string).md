#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PrivateTrading](./BitBayClient-PrivateTrading.md 'BitBayClient.PrivateTrading')
## PrivateTrading.ChangeConfiguration(string, string, string) Method
Change default ballance on market. For use must autorize User. Pair build first-second, for example BTC-USD btc is first, usd is second.  
```csharp
public bool ChangeConfiguration(string currencyPair, string ballanceIdForFirstCurrence, string BallanceIdForSecondCurrence);
```
#### Parameters
<a name='BitBayClient-PrivateTrading-ChangeConfiguration(string_string_string)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code.  
  
<a name='BitBayClient-PrivateTrading-ChangeConfiguration(string_string_string)-ballanceIdForFirstCurrence'></a>
`ballanceIdForFirstCurrence` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Balance UUID for first currency in pair.  
  
<a name='BitBayClient-PrivateTrading-ChangeConfiguration(string_string_string)-BallanceIdForSecondCurrence'></a>
`BallanceIdForSecondCurrence` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Balance UUID for second currency in pair  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Return true if change configuration successful or return false else.  
