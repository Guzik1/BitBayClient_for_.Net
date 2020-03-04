using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitBayClient.ResponseModel.Temp
{
    internal class FailResponseTemp: IResponseConvert<FailResponse>
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
                ErrorMessage emsg = ErrorMessageExtension.Parse(Errors[i]);

                output.Add(emsg);
            }

            return output;
        }
    }
}
