using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    internal interface IResponseConvert<Type>
    {
        public Type GetResponse();
    }
}
