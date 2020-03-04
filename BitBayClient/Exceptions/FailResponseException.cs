using System;
using System.Collections.Generic;

namespace BitBayClient.Exceptions
{
    [Serializable]
    public class FailResponseException : Exception
    {
        public List<ErrorMessage> Errors = new List<ErrorMessage>();

        public FailResponseException() : base() { }

        public FailResponseException(List<ErrorMessage> errors) : base()
        {
            Errors = errors;
        }

        public FailResponseException(string message) : base(message) { }

        public FailResponseException(string message, List<ErrorMessage> errors) : base(message)
        {
            Errors = errors;
        }

        public FailResponseException(string message, Exception inner) : base(message, inner) { }

        public FailResponseException(string message, Exception inner, List<ErrorMessage> errors) : base(message, inner)
        {
            Errors = errors;
        }
    }
}
