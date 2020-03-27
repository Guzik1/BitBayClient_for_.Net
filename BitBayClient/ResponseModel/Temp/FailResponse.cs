using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using BitBayClient.Converters;

namespace BitBayClient.ResponseModel.Temp
{
    internal class FailResponseTemp
    {
        public List<string> Errors { get; set; }

        public FailResponse GetResponse()
        {
            return new FailResponse() { 
                Errors = GetErrorsList() 
            };
        }

        private List<ErrorMessage> GetErrorsList()
        {
            if (Errors == null)
                return new List<ErrorMessage>();

            List<ErrorMessage> output = new List<ErrorMessage>();

            for (int i = 0; i < Errors.Count; i++)
            {
                ErrorMessage emsg = EnumConverter.Parse<ErrorMessage>(Errors[i]);

                output.Add(emsg);
            }

            return output;
        }
    }
}
