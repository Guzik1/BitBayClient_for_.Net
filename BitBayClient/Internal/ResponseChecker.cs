using System;
using System.Collections.Generic;
using System.Text;
using RestApiClient;

namespace BitBayClient.Internal
{
    public class ResponseChecker : IResponseChecker
    {
        public bool CheckResponseIsOk(string response)
        {
            if (response.Contains("\"status\":\"Fail\""))
                return false;

            return true;
        }
    }
}
