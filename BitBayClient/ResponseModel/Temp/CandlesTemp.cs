using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    internal class CandlesTemp: DeserializeWithTempObject<Candles>
    {
        public List<List<object>> Items { get; set; }

        Candles DeserializeWithTempObject<Candles>.Convert()
        {
            Dictionary<long, CandleItem> output = new Dictionary<long, CandleItem>();

            for (int i = 0; i < Items.Count; i++)
            {
                long time = long.Parse((string)Items[i][0]);
                CandleItem ci = Converters.Deserialize.FromJson<CandleItem>(Items[i][1].ToString());

                output.Add(time, ci);
            }

            return new Candles() { CandlesList = output };
        }
    }
}
