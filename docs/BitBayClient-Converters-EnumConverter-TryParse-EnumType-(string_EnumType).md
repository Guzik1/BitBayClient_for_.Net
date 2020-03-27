#### [BitBayClient](./index.md 'index')
### [BitBayClient.Converters](./BitBayClient-Converters.md 'BitBayClient.Converters').[EnumConverter](./BitBayClient-Converters-EnumConverter.md 'BitBayClient.Converters.EnumConverter')
## EnumConverter.TryParse&lt;EnumType&gt;(string, EnumType) Method
Try convert string to enum value.  
```csharp
public static bool TryParse<EnumType>(string name, ref EnumType message);
```
#### Type parameters
<a name='BitBayClient-Converters-EnumConverter-TryParse-EnumType-(string_EnumType)-EnumType'></a>
`EnumType`  
  
#### Parameters
<a name='BitBayClient-Converters-EnumConverter-TryParse-EnumType-(string_EnumType)-name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
String name to convert.  
  
<a name='BitBayClient-Converters-EnumConverter-TryParse-EnumType-(string_EnumType)-message'></a>
`message` [EnumType](#BitBayClient-Converters-EnumConverter-TryParse-EnumType-(string_EnumType)-EnumType 'BitBayClient.Converters.EnumConverter.TryParse&lt;EnumType&gt;(string, EnumType).EnumType')  
Enum value.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if try was successful or false for else.  
