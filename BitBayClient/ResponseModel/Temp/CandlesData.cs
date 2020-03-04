using BitBayClient.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    internal class CandlesDataTemp: IResponseConvert<CandlesData>
    {
        public Dictionary<long, CandleItem> Items { get; set; }

        public CandlesData GetResponse()
        {
            CandlesData output = new CandlesData();

            output.Candles = new Dictionary<DateTime, CandleItem>();

            foreach(KeyValuePair<long, CandleItem> item in Items)
            {
                DateTime dt = Date.Convert(item.Key);

                output.Candles.Add(dt, item.Value);
            }

            return output;
        }
    }
}
