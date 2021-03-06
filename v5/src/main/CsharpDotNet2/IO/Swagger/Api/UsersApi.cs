using System.Collections.Generic;
using AdobeSignClient.V5.Client;
using AdobeSignClient.V5.Model;
using RestSharp;

namespace AdobeSignClient.V5.Api
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
        ///     &lt;/ul&gt;
        /// </param>
        /// <param name="userCreationInfo"></param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>UserCreationResponse</returns>
        UserCreationResponse CreateUser(string accessToken, UserCreationInfo userCreationInfo, string xApiUser);

        /// <summary>
        ///     Retrieve detailed information about the user in the caller account. If caller is neither an account admin nor group
        ///     admin then some user information won&#39;t be returned.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_read&lt;/a&gt;&lt;/li&gt;&lt;
        ///     /ul&gt;
        /// </param>
        /// <param name="userId">
        ///     The user identifier, as returned by the user creation API or retrieved from the API to fetch
        ///     users. To get the details for the token owner, UserId can be replaced by \&quot;me\&quot; without quotes.
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>UserDetailsInfo</returns>
        UserDetailsInfo GetUserDetail(string accessToken, string userId, string xApiUser);

        /// <summary>
        ///     Retrieves all the users in an account.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_read&lt;/a&gt;&lt;/li&gt;&lt;
        ///     /ul&gt;
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <param name="xUserEmail">The email address of the user whose details are being requested</param>
        /// <returns>UsersInfo</returns>
        UsersInfo GetUsers(string accessToken, string xApiUser, string xUserEmail);

        /// <summary>
        ///     Update an user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_write&lt;/a&gt;&lt;/li&gt;
        ///     &lt;/ul&gt;
        /// </param>
        /// <param name="userId">The user identifier, as provided by GET /users or POST /users</param>
        /// <param name="userModificationInfo"></param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>UserDetailsInfo</returns>
        UserDetailsInfo ModifyUser(string accessToken, string userId, UserModificationInfo userModificationInfo, string xApiUser);

        /// <summary>
        ///     Activate/Deactivate a given user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_write&lt;/a&gt;&lt;/li&gt;
        ///     &lt;/ul&gt;
        /// </param>
        /// <param name="userId">The user identifier, as provided by GET /users or POST /users</param>
        /// <param name="userStatusUpdateInfo">User status update information object.</param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>UserStatusUpdateResponse</returns>
        UserStatusUpdateResponse ModifyUserStatus(string accessToken, string userId, UserStatusUpdateInfo userStatusUpdateInfo, string xApiUser);
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
        ///     &lt;/ul&gt;
        /// </param>
        /// <param name="userCreationInfo"></param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>UserCreationResponse</returns>
        public UserCreationResponse CreateUser(string accessToken, UserCreationInfo userCreationInfo, string xApiUser)
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
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
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
        ///     Retrieve detailed information about the user in the caller account. If caller is neither an account admin nor group
        ///     admin then some user information won&#39;t be returned.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_read&lt;/a&gt;&lt;/li&gt;&lt;
        ///     /ul&gt;
        /// </param>
        /// <param name="userId">
        ///     The user identifier, as returned by the user creation API or retrieved from the API to fetch
        ///     users. To get the details for the token owner, UserId can be replaced by \&quot;me\&quot; without quotes.
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>UserDetailsInfo</returns>
        public UserDetailsInfo GetUserDetail(string accessToken, string userId, string xApiUser)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetUserDetail");

            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserDetail");


            string path = "/users/{userId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetUserDetail: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetUserDetail: " + response.ErrorMessage, response.ErrorMessage);

            return (UserDetailsInfo) ApiClient.Deserialize(response.Content, typeof(UserDetailsInfo), response.Headers);
        }

        /// <summary>
        ///     Retrieves all the users in an account.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_read&lt;/a&gt;&lt;/li&gt;&lt;
        ///     /ul&gt;
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <param name="xUserEmail">The email address of the user whose details are being requested</param>
        /// <returns>UsersInfo</returns>
        public UsersInfo GetUsers(string accessToken, string xApiUser, string xUserEmail)
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

            if (xUserEmail != null) queryParams.Add("x-user-email", ApiClient.ParameterToString(xUserEmail)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter

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
        ///     Update an user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_write&lt;/a&gt;&lt;/li&gt;
        ///     &lt;/ul&gt;
        /// </param>
        /// <param name="userId">The user identifier, as provided by GET /users or POST /users</param>
        /// <param name="userModificationInfo"></param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>UserDetailsInfo</returns>
        public UserDetailsInfo ModifyUser(string accessToken, string userId, UserModificationInfo userModificationInfo, string xApiUser)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling ModifyUser");

            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling ModifyUser");

            // verify the required parameter 'userModificationInfo' is set
            if (userModificationInfo == null) throw new ApiException(400, "Missing required parameter 'userModificationInfo' when calling ModifyUser");


            string path = "/users/{userId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            postBody = ApiClient.Serialize(userModificationInfo); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling ModifyUser: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling ModifyUser: " + response.ErrorMessage, response.ErrorMessage);

            return (UserDetailsInfo) ApiClient.Deserialize(response.Content, typeof(UserDetailsInfo), response.Headers);
        }

        /// <summary>
        ///     Activate/Deactivate a given user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_write&lt;/a&gt;&lt;/li&gt;
        ///     &lt;/ul&gt;
        /// </param>
        /// <param name="userId">The user identifier, as provided by GET /users or POST /users</param>
        /// <param name="userStatusUpdateInfo">User status update information object.</param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>UserStatusUpdateResponse</returns>
        public UserStatusUpdateResponse ModifyUserStatus(string accessToken, string userId, UserStatusUpdateInfo userStatusUpdateInfo, string xApiUser)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling ModifyUserStatus");

            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling ModifyUserStatus");

            // verify the required parameter 'userStatusUpdateInfo' is set
            if (userStatusUpdateInfo == null) throw new ApiException(400, "Missing required parameter 'userStatusUpdateInfo' when calling ModifyUserStatus");


            string path = "/users/{userId}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            postBody = ApiClient.Serialize(userStatusUpdateInfo); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling ModifyUserStatus: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling ModifyUserStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (UserStatusUpdateResponse) ApiClient.Deserialize(response.Content, typeof(UserStatusUpdateResponse), response.Headers);
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