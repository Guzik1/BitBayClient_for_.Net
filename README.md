# BitBay client rest api for C#/.Net
This project is a client for BitBay crypto exchange rest api.

## General info

## Setup
Lib BitBay client available soon in nuget package.<br />
View [BitBay api documentation](https://docs.bitbay.net/v1.0.1-en/reference#ticker-1) for get all api method and data model.

## Simple code example
Example for get ticker for BTCUSD market.
```C#
BitBayClient bbc = new BitBayClient();
Ticker bitcoinTicker = bbc.PublicTrading.GetTicker("BTCUSD");
```
For more information, you must view [lib documentation](https://github.com/Guzik1/BitBayClient_for_.Net/blob/master/docs/index.md). <br />

## Built with
- .Net Core 3.1
- NUnit Framework (for testing)
- [Rest api client](https://github.com/Guzik1/RestApiClient_for_.Net) for c# (MIT license)

## Status
Version: 1.0.0<br />

## License
[MIT License](https://github.com/Guzik1/BitBayClient_for_.Net/blob/master/LICENSE) © [Sebastian Guzik](https://github.com/Guzik1).
