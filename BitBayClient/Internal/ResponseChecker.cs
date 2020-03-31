using System;
using System.Collections.Generic;
using System.Text;
using RestApiClient;

namespace BitBayClient.Internal
{
    /// <summary>
    /// Respone check class, implement IResponseChecker interface from RestApiClient.
    /// </summary>
    public class ResponseChecker : IResponseChecker
    {
        /// <summary>
        /// Check response is correct.
        /// </summary>
        /// <param name="response">string response</param>
        /// <returns>true if response has no error or false in another else case.</returns>
        public bool CheckResponseIsOk(string response)
        {
            if (response.Contains("\"Fail\"") || response.Contains("\"errors\""))
                return false;

            return true;
        }
    }
}
