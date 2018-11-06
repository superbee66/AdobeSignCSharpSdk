using System.Collections.Generic;
using AdobeSignClient.V6.Client;
using AdobeSignClient.V6.Model;
using RestSharp;

namespace AdobeSignClient.V6.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBaseUrisApi
    {
        /// <summary>
        ///     Gets the base uri to access other APIs. In case other APIs are accessed from a different end point, it will be
        ///     considered an invalid request.
        /// </summary>
        /// <param name="authorization">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with any of the valid scopes&lt;ul&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.
        /// </param>
        /// <returns>BaseUriInfo</returns>
        BaseUriInfo GetBaseUris(string authorization);
    }

    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BaseUrisApi : IBaseUrisApi
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseUrisApi" /> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BaseUrisApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                ApiClient = Configuration.DefaultApiClient;
            else
                ApiClient = apiClient;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseUrisApi" /> class.
        /// </summary>
        /// <returns></returns>
        public BaseUrisApi(string basePath)
        {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        ///     Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///     Gets the base uri to access other APIs. In case other APIs are accessed from a different end point, it will be
        ///     considered an invalid request.
        /// </summary>
        /// <param name="authorization">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with any of the valid scopes&lt;ul&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.
        /// </param>
        /// <returns>BaseUriInfo</returns>
        public BaseUriInfo GetBaseUris(string authorization)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling GetBaseUris");


            string path = "/baseUris";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetBaseUris: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetBaseUris: " + response.ErrorMessage, response.ErrorMessage);

            return (BaseUriInfo) ApiClient.Deserialize(response.Content, typeof(BaseUriInfo), response.Headers);
        }

        /// <summary>
        ///     Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public string GetBasePath(string basePath) => ApiClient.BasePath;

        /// <summary>
        ///     Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(string basePath)
        {
            ApiClient.BasePath = basePath;
        }
    }
}