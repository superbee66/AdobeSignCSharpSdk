using System;
using System.Collections.Generic;
using AdobeSignClient.V1.Client;
using AdobeSignClient.V1.Model;
using RestSharp;

namespace AdobeSignClient.V1.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApi
    {
        /// <summary>
        /// Issues an access token for a user of an application. Application credentials can be obtained from the Adobe Sign Application page. User credentials can be a combination of email and password, or the API key of the user. The access token returned by this endpoint has a validity of 14 days and is a required header parameter for all the other endpoints that requires an authenticated user.  NOTE: This endpoint is deprecated and will be removed in a future release - please use an &lt;a href&#x3D;\&quot;javascript:void(0)\&quot; onclick&#x3D;\&quot;window.open(oauthDoc(),&#39;oauthDoc&#39;).focus()\&quot;&gt;OAuth Access Token&lt;/a&gt; instead.
        /// </summary>
        /// <param name="rESTCredentials">The user and application credentials to use for issuing the access token.</param>
        /// <returns>AccessToken</returns>
        AccessToken CreateAccessToken (RESTCredentials rESTCredentials);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TokensApi : ITokensApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TokensApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokensApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Issues an access token for a user of an application. Application credentials can be obtained from the Adobe Sign Application page. User credentials can be a combination of email and password, or the API key of the user. The access token returned by this endpoint has a validity of 14 days and is a required header parameter for all the other endpoints that requires an authenticated user.  NOTE: This endpoint is deprecated and will be removed in a future release - please use an &lt;a href&#x3D;\&quot;javascript:void(0)\&quot; onclick&#x3D;\&quot;window.open(oauthDoc(),&#39;oauthDoc&#39;).focus()\&quot;&gt;OAuth Access Token&lt;/a&gt; instead.
        /// </summary>
        /// <param name="rESTCredentials">The user and application credentials to use for issuing the access token.</param> 
        /// <returns>AccessToken</returns>            
        public AccessToken CreateAccessToken (RESTCredentials rESTCredentials)
        {
            
            // verify the required parameter 'rESTCredentials' is set
            if (rESTCredentials == null) throw new ApiException(400, "Missing required parameter 'rESTCredentials' when calling CreateAccessToken");
            
    
            var path = "/auth/tokens";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(rESTCredentials); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAccessToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAccessToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessToken) ApiClient.Deserialize(response.Content, typeof(AccessToken), response.Headers);
        }
    
    }
}
