#### [BitBayClient](./index.md 'index')
### [BitBayClient.RequestModel](./BitBayClient-RequestModel.md 'BitBayClient.RequestModel').[AutorizeData](./BitBayClient-RequestModel-AutorizeData.md 'BitBayClient.RequestModel.AutorizeData')
## AutorizeData.AddOwnHeaderPOST(object) Method
Generate autorization header for POST methods.  
```csharp
public System.Collections.Generic.Dictionary<string,string> AddOwnHeaderPOST(object POSTDataToSend);
```
#### Parameters
<a name='BitBayClient-RequestModel-AutorizeData-AddOwnHeaderPOST(object)-POSTDataToSend'></a>
`POSTDataToSend` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
Json object with data to send in query.  
  
#### Returns
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')  
Dictonar, key is param name, value is value of this param.  
