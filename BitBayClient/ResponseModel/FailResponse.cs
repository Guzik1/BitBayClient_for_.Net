using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using BitBayClient;

namespace BitBayClient.ResponseModel
{
    public class FailResponse
    {
        public List<string> Errors { get; set; }

        List<ErrorMessage> ErrorMessages { get; set; }

        bool convert = false;

        public List<ErrorMessage> GetErrorsList()
        {
            if (!convert)
            {
                ErrorMessages = new List<ErrorMessage>();

                for (int i = 0; i < Errors.Count; i++)
                {
                    ErrorMessage emsg = ErrorMessageExtension.Parse(Errors[i]);

                    ErrorMessages.Add(emsg);
                }

                return ErrorMessages;
            }

            if(ErrorMessages == null)
                return new List<ErrorMessage>();

            return ErrorMessages;
        }
    }
}
