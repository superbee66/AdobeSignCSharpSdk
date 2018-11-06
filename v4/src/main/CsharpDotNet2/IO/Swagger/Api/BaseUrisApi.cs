using System.Collections.Generic;
using AdobeSignClient.V4.Client;
using AdobeSignClient.V4.Model;
using RestSharp;

namespace AdobeSignClient.V4.Api
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
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;
        ///     \&quot;this.href&#x3D;oauthDoc(&#39;agreement_sign&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;agreement_sign&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_sign&lt;/a&gt;&lt;/li&gt;&lt;li
        ///     style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;
        ///     oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write
        ///     &#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;
        ///     list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     agreement_retention&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_retention&#39;)\
        ///     &quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_retention&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;
        ///     list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target
        ///     &#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square
        ///     &#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\
        ///     &quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; target&#x3D;\&quot;
        ///     oauthDoc\&quot;&gt;library_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a
        ///     href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_retention&#39;)\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_retention&#39;)\&quot; target&#x3D;\&quot;oauthDoc\
        ///     &quot;&gt;library_retention&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href
        ///     &#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\
        ///     &quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a
        ///     &gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;
        ///     \&quot;this.href&#x3D;oauthDoc(&#39;user_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     user_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_read&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;
        ///     list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     user_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_write&#39;)\&quot; target&#x3D;
        ///     \&quot;oauthDoc\&quot;&gt;user_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;
        ///     &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;
        ///     &gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;
        ///     #\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;
        ///     &lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\
        ///     &quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_send&lt;/a&gt;&lt;/li&gt;&lt;li
        ///     style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;
        ///     oauthDoc(&#39;workflow_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;workflow_read&#39;
        ///     )\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;workflow_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <returns>BaseUriInfo</returns>
        BaseUriInfo GetBaseUris(string accessToken);
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
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;
        ///     \&quot;this.href&#x3D;oauthDoc(&#39;agreement_sign&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;agreement_sign&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_sign&lt;/a&gt;&lt;/li&gt;&lt;li
        ///     style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;
        ///     oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write
        ///     &#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;
        ///     list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     agreement_retention&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_retention&#39;)\
        ///     &quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_retention&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;
        ///     list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target
        ///     &#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square
        ///     &#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\
        ///     &quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; target&#x3D;\&quot;
        ///     oauthDoc\&quot;&gt;library_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a
        ///     href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_retention&#39;)\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_retention&#39;)\&quot; target&#x3D;\&quot;oauthDoc\
        ///     &quot;&gt;library_retention&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href
        ///     &#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\
        ///     &quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a
        ///     &gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;
        ///     \&quot;this.href&#x3D;oauthDoc(&#39;user_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     user_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_read&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;
        ///     list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     user_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_write&#39;)\&quot; target&#x3D;
        ///     \&quot;oauthDoc\&quot;&gt;user_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;
        ///     &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;
        ///     &gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;
        ///     #\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;
        ///     &lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\
        ///     &quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_send&lt;/a&gt;&lt;/li&gt;&lt;li
        ///     style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;
        ///     oauthDoc(&#39;workflow_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;workflow_read&#39;
        ///     )\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;workflow_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <returns>BaseUriInfo</returns>
        public BaseUriInfo GetBaseUris(string accessToken)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetBaseUris");


            string path = "/base_uris";
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