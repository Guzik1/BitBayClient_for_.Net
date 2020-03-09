using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using BitBayClient;

namespace BitBayClient.ResponseModel
{
    public class FailResponse
    {
        public List<ErrorMessage> Errors { get; set; }
    }
}
