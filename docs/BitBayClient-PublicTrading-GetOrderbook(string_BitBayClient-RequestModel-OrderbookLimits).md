#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient').[PublicTrading](./BitBayClient-PublicTrading.md 'BitBayClient.PublicTrading')
## PublicTrading.GetOrderbook(string, BitBayClient.RequestModel.OrderbookLimits) Method
Get orderbook with own limit of sell and buy offers, from rest api.  
```csharp
public BitBayClient.ResponseModel.Orderbook GetOrderbook(string currencyPair, BitBayClient.RequestModel.OrderbookLimits limit);
```
#### Parameters
<a name='BitBayClient-PublicTrading-GetOrderbook(string_BitBayClient-RequestModel-OrderbookLimits)-currencyPair'></a>
`currencyPair` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Currency pair code, example BTC-USD.  
  
<a name='BitBayClient-PublicTrading-GetOrderbook(string_BitBayClient-RequestModel-OrderbookLimits)-limit'></a>
`limit` [OrderbookLimits](./BitBayClient-RequestModel-OrderbookLimits.md 'BitBayClient.RequestModel.OrderbookLimits')  
Limit of offer count (available limits: 10, 50, 100). Limit must be less or equal 300.  
  
#### Returns
[Orderbook](./BitBayClient-ResponseModel-Orderbook.md 'BitBayClient.ResponseModel.Orderbook')  
Orderbook with own limit offers of buy and sell.  
