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
            {
                string response = rc.GetResponseToString;

                return Deserialize.FromJson<Expected>(response);

                //return rc.GetResponse<Expected>();
            }

            throw new Exception("Unknown error.");
        }

        public static Expected TryGetResponse<Expected, Temp>(RestClient rc)
        {
            if (CheckResult(rc))
            {
                string response = rc.GetResponseToString;

                Temp temp = Deserialize.FromJson<Temp>(response);
                DeserializeWithTempObject<Expected> converter = (DeserializeWithTempObject<Expected>)temp;

                return converter.Convert();
            }

            throw new Exception("Unknown error.");
        }

        public static bool CheckResult(RestClient rc)
        {
            if (rc.ResponseHasNoErrors(new ResponseChecker()))
            {
                return true;
            }
            else if(rc.ResponseHasSuccessStatusCode)
            {
                string response = rc.GetResponseToString;

                FailResponseTemp frt = Deserialize.FromJson<FailResponseTemp>(response);
                FailResponse fr = frt.GetResponse();

                throw new FailResponseException("Server was return error response. Check error list for more informations.", fr.Errors);
            }

            FailResponseTemp frt2 = Deserialize.FromJson<FailResponseTemp>(rc.GetResponseToString);

            if(frt2 == null)
                throw new FailResponseException(frt2.Errors[0]);
            else
                throw new FailResponseException();
        }
    }
}
