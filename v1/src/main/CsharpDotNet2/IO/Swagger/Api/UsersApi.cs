using System.Collections.Generic;
using AdobeSignClient.V1.Client;
using AdobeSignClient.V1.Model;
using RestSharp;

namespace AdobeSignClient.V1.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi
    {
        /// <summary>
        ///     Creates a new user in the Adobe Sign system
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_write&lt;/a&gt;&lt;/li&gt;
        ///     &lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)
        /// </param>
        /// <param name="userCreationInfo"></param>
        /// <returns>UserCreationResponse</returns>
        UserCreationResponse CreateUser(string accessToken, UserCreationInfo userCreationInfo);

        /// <summary>
        ///     Gets all the users in an account that the caller has permissions to access. Account admins will get all the users
        ///     in their account, group admins will get all users in their group. If caller is neither an account admin nor group
        ///     admin then their own information is returned.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_read&lt;/a&gt;&lt;/li&gt;&lt;
        ///     /ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)
        /// </param>
        /// <returns>UsersInfo</returns>
        UsersInfo GetUsers(string accessToken);
    }

    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UsersApi" /> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                ApiClient = Configuration.DefaultApiClient;
            else
                ApiClient = apiClient;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="UsersApi" /> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(string basePath)
        {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        ///     Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///     Creates a new user in the Adobe Sign system
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_write&lt;/a&gt;&lt;/li&gt;
        ///     &lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)
        /// </param>
        /// <param name="userCreationInfo"></param>
        /// <returns>UserCreationResponse</returns>
        public UserCreationResponse CreateUser(string accessToken, UserCreationInfo userCreationInfo)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateUser");

            // verify the required parameter 'userCreationInfo' is set
            if (userCreationInfo == null) throw new ApiException(400, "Missing required parameter 'userCreationInfo' when calling CreateUser");


            string path = "/users";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            postBody = ApiClient.Serialize(userCreationInfo); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling CreateUser: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling CreateUser: " + response.ErrorMessage, response.ErrorMessage);

            return (UserCreationResponse) ApiClient.Deserialize(response.Content, typeof(UserCreationResponse), response.Headers);
        }

        /// <summary>
        ///     Gets all the users in an account that the caller has permissions to access. Account admins will get all the users
        ///     in their account, group admins will get all users in their group. If caller is neither an account admin nor group
        ///     admin then their own information is returned.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_read&lt;/a&gt;&lt;/li&gt;&lt;
        ///     /ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)
        /// </param>
        /// <returns>UsersInfo</returns>
        public UsersInfo GetUsers(string accessToken)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetUsers");


            string path = "/users";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetUsers: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetUsers: " + response.ErrorMessage, response.ErrorMessage);

            return (UsersInfo) ApiClient.Deserialize(response.Content, typeof(UsersInfo), response.Headers);
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