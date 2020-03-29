#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PublicTrading](./BitBayClient-PublicTrading.md 'BitBayClient.PublicTrading')
## PublicTrading.GetLastTransactions(string, long) Method
Get last transaction, start from unixtimestamp. Return list from "items" property in api response.  
```csharp
public System.Collections.Generic.List<BitBayClient.ResponseModel.LastTransactionItem> GetLastTransactions(string currencyPair, long fromTimeUnix);
```
#### Parameters
<a name='BitBayClient-PublicTrading-GetLastTransactions(string_long)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code.  
  
<a name='BitBayClient-PublicTrading-GetLastTransactions(string_long)-fromTimeUnix'></a>
`fromTimeUnix` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
Unix timestam from start geting result.  
  
#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[LastTransactionItem](./BitBayClient-ResponseModel-LastTransactionItem.md 'BitBayClient.ResponseModel.LastTransactionItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
List of last transactions, started from unix timestamp.  
