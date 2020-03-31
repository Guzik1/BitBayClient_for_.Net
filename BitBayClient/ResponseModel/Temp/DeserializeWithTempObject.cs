using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    internal interface DeserializeWithTempObject<Expected>
    {
        internal Expected Convert();
    }
}
