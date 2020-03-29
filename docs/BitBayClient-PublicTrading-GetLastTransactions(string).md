#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PublicTrading](./BitBayClient-PublicTrading.md 'BitBayClient.PublicTrading')
## PublicTrading.GetLastTransactions(string) Method
Get last 10 transaction. Return list from "items" property in api response.  
```csharp
public System.Collections.Generic.List<BitBayClient.ResponseModel.LastTransactionItem> GetLastTransactions(string currencyPair);
```
#### Parameters
<a name='BitBayClient-PublicTrading-GetLastTransactions(string)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code.  
  
#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[LastTransactionItem](./BitBayClient-ResponseModel-LastTransactionItem.md 'BitBayClient.ResponseModel.LastTransactionItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
List of last transactions, list count 10.  
