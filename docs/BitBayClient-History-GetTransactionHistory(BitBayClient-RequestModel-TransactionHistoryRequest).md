#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[History](./BitBayClient-History.md 'BitBayClient.History')
## History.GetTransactionHistory(BitBayClient.RequestModel.TransactionHistoryRequest) Method
Get transaction history from user account. For use, must authorize User.  
```csharp
public BitBayClient.ResponseModel.TransactionHistory GetTransactionHistory(BitBayClient.RequestModel.TransactionHistoryRequest body);
```
#### Parameters
<a name='BitBayClient-History-GetTransactionHistory(BitBayClient-RequestModel-TransactionHistoryRequest)-body'></a>
`body` [TransactionHistoryRequest](./BitBayClient-RequestModel-TransactionHistoryRequest.md 'BitBayClient.RequestModel.TransactionHistoryRequest')  
Transaction history body request.  
  
#### Returns
[TransactionHistory](./BitBayClient-ResponseModel-TransactionHistory.md 'BitBayClient.ResponseModel.TransactionHistory')  
Transaction history object.  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Throw when body parameter is null.  
