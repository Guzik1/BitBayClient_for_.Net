#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PublicTrading](./BitBayClient-PublicTrading.md 'BitBayClient.PublicTrading')
## PublicTrading.GetOrderbook(string) Method
Get orderbook with 300 higher buy and 300 lowest sell offers, from rest api.  
```csharp
public BitBayClient.ResponseModel.Orderbook GetOrderbook(string currencyPair);
```
#### Parameters
<a name='BitBayClient-PublicTrading-GetOrderbook(string)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code, format example: BTC-USD.  
  
#### Returns
[Orderbook](./BitBayClient-ResponseModel-Orderbook.md 'BitBayClient.ResponseModel.Orderbook')  
Orderbook with 300 higher buy and 300 lowest sell offers.  
