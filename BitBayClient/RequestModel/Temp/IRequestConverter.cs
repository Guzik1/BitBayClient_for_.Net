using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.RequestModel.Temp
{
    internal interface IRequestConverter<TempType>
    {
        public void SetRequest(TempType fromObject);
    }
}
