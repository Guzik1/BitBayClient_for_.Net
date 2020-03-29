#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[History](./BitBayClient-History.md 'BitBayClient.History')
## History.GetOperationHistory(BitBayClient.RequestModel.OperationHistoryRequest) Method
Get operation history from user account on exchange. For use, must authorize User.  
```csharp
public BitBayClient.ResponseModel.OperationHistory GetOperationHistory(BitBayClient.RequestModel.OperationHistoryRequest request);
```
#### Parameters
<a name='BitBayClient-History-GetOperationHistory(BitBayClient-RequestModel-OperationHistoryRequest)-request'></a>
`request` [OperationHistoryRequest](./BitBayClient-RequestModel-OperationHistoryRequest.md 'BitBayClient.RequestModel.OperationHistoryRequest')  
Operation history request object.  
  
#### Returns
[OperationHistory](./BitBayClient-ResponseModel-OperationHistory.md 'BitBayClient.ResponseModel.OperationHistory')  
Operation history.  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Throw when body parameter is null.  
