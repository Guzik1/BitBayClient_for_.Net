using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using BitBayClient;

namespace BitBayClient.ResponseModel
{
    /// <summary>
    /// Data model for fail response on another request.
    /// </summary>
    public class FailResponse
    {
        /// <summary>
        /// List of error messages.
        /// </summary>
        public List<ErrorMessage> Errors { get; set; }
    }
}
