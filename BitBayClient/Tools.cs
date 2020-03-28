using BitBayClient.Exceptions;
using BitBayClient.Internal;
using BitBayClient.Converters;
using BitBayClient.ResponseModel;
using BitBayClient.ResponseModel.Temp;
using RestApiClient;
using System;

namespace BitBayClient
{
    internal static class Tools
    {
        public static Expected TryGetResponse<Expected>(RestClient rc)
        {
            if (CheckResult(rc))
                return rc.GetResponse<Expected>();

            throw new Exception("Unknown error.");
        }

        public static bool CheckResult(RestClient rc)
        {
            if (rc.ResponseHasNoErrors(new ResponseChecker()))
            {
                return true;
            }
            else if (rc.ResponseHasSuccessStatusCode)
            {
                string response = rc.GetResponseToString;

                FailResponseTemp frt = Deserialize.FromJson<FailResponseTemp>(response);
                FailResponse fr = frt.GetResponse();

                throw new FailResponseException("Server was return error response. Check error list for more informations.", fr.Errors);
            }

            return false;
        }
    }
}
