using System;

namespace AdobeSignClient.V6.Client
{
    /// <summary>
    ///     API Exception
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ApiException" /> class.
        /// </summary>
        public ApiException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApiException" /> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        public ApiException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApiException" /> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content.</param>
        public ApiException(int errorCode, string message, object errorContent = null) : base(message)
        {
            ErrorCode = errorCode;
            ErrorContent = errorContent;
        }

        /// <summary>
        ///     Gets or sets the error code (HTTP status code)
        /// </summary>
        /// <value>The error code (HTTP status code).</value>
        public int ErrorCode { get; set; }

        /// <summary>
        ///     Gets or sets the error content (body json object)
        /// </summary>
        /// <value>The error content (Http response body).</value>
        public object ErrorContent { get; }
    }
}