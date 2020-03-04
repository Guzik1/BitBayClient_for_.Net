using BitBayClient.Exceptions;
using BitBayClient.Internal;
using BitBayClient.Converters;
using BitBayClient.ResponseModel;
using BitBayClient.ResponseModel.Temp;
using RestApiClient;
using System;

namespace BitBayClient
{
    public partial class BitBayClient
    {
        Expected TryGetResponse<Expected>(RestClient rc)
        {
            if (CheckResult(rc))
                return rc.GetResponse<Expected>();

            throw new Exception("Unknown error.");
        }

        Expected TryGetResponse<Expected, Temp>(RestClient rc)
        {
            if (CheckResult(rc))
            {
                string response = rc.GetResponseToString;

                Temp temp = Deserialize.FromJson<Temp>(response);
                IResponseConvert<Expected> con = (IResponseConvert<Expected>)temp;

                return con.GetResponse();
            }

            throw new Exception("Unknown error.");
        }

        bool CheckResult(RestClient rc)
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
