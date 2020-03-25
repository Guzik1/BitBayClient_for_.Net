using System;
using System.Collections.Generic;
using System.Text;
using RestApiClient;
using BitBayClient.Converters;
using BitBayClient;

namespace BitBayClient.RequestModel
{
    internal class AutorizeData : IAddOwnHeaderToRequest
    {
        string unixTS = Date.Convert(DateTime.Now).ToString();
        Config config;

        internal AutorizeData(Config config)
        {
            this.config = config;
        }

        public Dictionary<string, string> AddOwnHeader()
        {
            string hash = GenerateHash(config.PublicKey, unixTS);

            return AddAutorizationHeader(hash);
        }

        public Dictionary<string, string> AddOwnHeaderPOST(object POSTDataToSend)
        {
            string JsonSerializedObject = Serialize.AsJson(POSTDataToSend);

            string hash = GenerateHash(config.PublicKey, unixTS, JsonSerializedObject);

            return AddAutorizationHeader(hash);
        }

        Dictionary<string, string> AddAutorizationHeader(string hash)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();

            headers.Add("Request-Timestamp", unixTS);
            headers.Add("API-Key", config.PublicKey);
            headers.Add("operation-id", Guid.NewGuid().ToString());
            headers.Add("API-Hash", hash);

            return headers;
        }

        string GenerateHash(params string[] stringToMix)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < stringToMix.Length; i++)
                sb.Append(stringToMix[i]);

            return Hash.SHA512HMAC_ComputeHash(sb.ToString(), config.PrivateKey);
        }
    }
}
