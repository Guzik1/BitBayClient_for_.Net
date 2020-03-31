#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PublicTrading](./BitBayClient-PublicTrading.md 'BitBayClient.PublicTrading')
## PublicTrading.GetLastTransactions(string, int) Method
Get last limit count transaction. Return list from "items" property in api response.  
```csharp
public System.Collections.Generic.List<BitBayClient.ResponseModel.LastTransactionItem> GetLastTransactions(string currencyPair, int limit);
```
#### Parameters
<a name='BitBayClient-PublicTrading-GetLastTransactions(string_int)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code, example BTC-USD.  
  
<a name='BitBayClient-PublicTrading-GetLastTransactions(string_int)-limit'></a>
`limit` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Limit of result, max 300.  
  
#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[LastTransactionItem](./BitBayClient-ResponseModel-LastTransactionItem.md 'BitBayClient.ResponseModel.LastTransactionItem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
List of last transactions, list count is limited by limit (max 300).  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Throw if the limit is greater than 300.  
