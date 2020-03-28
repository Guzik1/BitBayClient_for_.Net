using System;
using System.Collections.Generic;

namespace BitBayClient.Exceptions
{
    /// <summary>
    /// Fail response exception
    /// </summary>
    [Serializable]
    public class FailResponseException : Exception
    {
        /// <summary>
        /// List of error messages.
        /// </summary>
        public List<ErrorMessage> Errors = new List<ErrorMessage>();

        /// <summary>
        /// Fail response exception.
        /// </summary>
        public FailResponseException() : base() { }

        /// <summary>
        /// Fail response exception with error list.
        /// </summary>
        /// <param name="errors">List of errors.</param>
        public FailResponseException(List<ErrorMessage> errors) : base()
        {
            Errors = errors;
        }

        /// <summary>
        /// Fail response exception with exception message.
        /// </summary>
        /// <param name="message">Exception error message string.</param>
        public FailResponseException(string message) : base(message) { }

        /// <summary>
        /// Fail response exception with error list and exception message.
        /// </summary>
        /// <param name="message">List of error message.</param>
        /// <param name="errors">Exception message string.</param>
        public FailResponseException(string message, List<ErrorMessage> errors) : base(message)
        {
            Errors = errors;
        }

        /// <summary>
        /// Fail response exception with exception message and inner exception stack.
        /// </summary>
        /// <param name="message">Exception error message string.</param>
        /// <param name="inner">Inner exception stack.</param>
        public FailResponseException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Fail response exception with exception message, inner exception stack and error list.
        /// </summary>
        /// <param name="message">Exception error message string.</param>
        /// <param name="inner">Inner exception stack.</param>
        /// <param name="errors">List of error message.</param>
        public FailResponseException(string message, Exception inner, List<ErrorMessage> errors) : base(message, inner)
        {
            Errors = errors;
        }
    }
}
