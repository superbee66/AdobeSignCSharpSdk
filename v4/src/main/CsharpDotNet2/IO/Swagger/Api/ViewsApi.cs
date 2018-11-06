using System.Collections.Generic;
using AdobeSignClient.V4.Client;
using AdobeSignClient.V4.Model;
using RestSharp;

namespace AdobeSignClient.V4.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IViewsApi
    {
        /// <summary>
        ///     Returns the URL for manage page. This endpoint will return the URL for manage page. If an agreement asset id is
        ///     given then that agreement asset will be shown selected in the resulted manage page url.The agreement asset refers
        ///     to any asset through which an agreement can be created for instance library document,widget and agreement itself.
        ///     If the user wants to generate a URL that will automatically log the user in then user_login scope is required in
        ///     the given Oauth Access Token.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - If the
        ///     user wants to generate a URL that will automatically log the user in then this  scope is required else any valid
        ///     scope can be used&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="xUserId">The ID of the user for whom URL is being generated.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user for whom URL is being generated. If both X-User-Id and
        ///     X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <param name="agreementAssetListRequest">Information about the type of url to be generated for Manage Page</param>
        /// <returns>ViewUrl</returns>
        ViewUrl CreateAgreementAssetListUrl(string accessToken, string xUserId, string xUserEmail, AgreementAssetListRequest agreementAssetListRequest);

        /// <summary>
        ///     Returns the URL which shows the view page of given agreement asset. This endpoint will return the URL of view
        ///     agreement page for an agreement asset. The agreement asset refers to any asset through which an agreement can be
        ///     created for instance library document,widget and agreement itself.                     If the user wants to
        ///     generate a URL that will automatically log the user in then user_login scope is required in the given Oauth Access
        ///     Token.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt; - Required when agreementAssetId refers to an agreement&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type:
        ///     square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\
        ///     &quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\
        ///     &quot;&gt;widget_read&lt;/a&gt; - Required when agreementAssetId refers to a widget&lt;/li&gt;&lt;li style&#x3D;
        ///     &#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot;
        ///     target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt; - Required when agreementAssetId refers to a library
        ///     document&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick
        ///     &#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;
        ///     oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - In addition to
        ///     one of the above scopes, this scope is required if the user wants to generate a URL that will automatically log the
        ///     user in.&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementAssetRequest">Information about the type of url to be generated for Agreement Asset Page</param>
        /// <param name="xUserId">The ID of the user for whom URL is being generated.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user for whom URL is being generated. If both X-User-Id and
        ///     X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <returns>ViewUrl</returns>
        ViewUrl CreateAgreementAssetUrl(string accessToken, AgreementAssetRequest agreementAssetRequest, string xUserId, string xUserEmail);

        /// <summary>
        ///     Returns the URL for settings page. This endpoint will return the URL for Settings Page. The settings page can be of
        ///     two types - user profile page(for non admin) and account settings page(for admin). If the user wants to generate a
        ///     URL that will automatically log the user in then user_login scope is required in the given Oauth Access Token.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - If the
        ///     user wants to generate a URL that will automatically log the user in then this  scope is required else any valid
        ///     scope can be used&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="targetViewRequest">Information about the type of url to be generated for various Settings page</param>
        /// <param name="xUserId">The ID of the user for whom URL is being generated.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user for whom URL is being generated. If both X-User-Id and
        ///     X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <returns>ViewUrl</returns>
        ViewUrl CreateSettingsUrl(string accessToken, TargetViewRequest targetViewRequest, string xUserId, string xUserEmail);
    }

    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ViewsApi : IViewsApi
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ViewsApi" /> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ViewsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                ApiClient = Configuration.DefaultApiClient;
            else
                ApiClient = apiClient;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ViewsApi" /> class.
        /// </summary>
        /// <returns></returns>
        public ViewsApi(string basePath)
        {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        ///     Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///     Returns the URL for manage page. This endpoint will return the URL for manage page. If an agreement asset id is
        ///     given then that agreement asset will be shown selected in the resulted manage page url.The agreement asset refers
        ///     to any asset through which an agreement can be created for instance library document,widget and agreement itself.
        ///     If the user wants to generate a URL that will automatically log the user in then user_login scope is required in
        ///     the given Oauth Access Token.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - If the
        ///     user wants to generate a URL that will automatically log the user in then this  scope is required else any valid
        ///     scope can be used&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="xUserId">The ID of the user for whom URL is being generated.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user for whom URL is being generated. If both X-User-Id and
        ///     X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <param name="agreementAssetListRequest">Information about the type of url to be generated for Manage Page</param>
        /// <returns>ViewUrl</returns>
        public ViewUrl CreateAgreementAssetListUrl(string accessToken, string xUserId, string xUserEmail, AgreementAssetListRequest agreementAssetListRequest)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateAgreementAssetListUrl");


            string path = "/views/agreementAssetList";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xUserId != null) headerParams.Add("x-user-id", ApiClient.ParameterToString(xUserId)); // header parameter
            if (xUserEmail != null) headerParams.Add("x-user-email", ApiClient.ParameterToString(xUserEmail)); // header parameter
            postBody = ApiClient.Serialize(agreementAssetListRequest); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling CreateAgreementAssetListUrl: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling CreateAgreementAssetListUrl: " + response.ErrorMessage, response.ErrorMessage);

            return (ViewUrl) ApiClient.Deserialize(response.Content, typeof(ViewUrl), response.Headers);
        }

        /// <summary>
        ///     Returns the URL which shows the view page of given agreement asset. This endpoint will return the URL of view
        ///     agreement page for an agreement asset. The agreement asset refers to any asset through which an agreement can be
        ///     created for instance library document,widget and agreement itself.                     If the user wants to
        ///     generate a URL that will automatically log the user in then user_login scope is required in the given Oauth Access
        ///     Token.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt; - Required when agreementAssetId refers to an agreement&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type:
        ///     square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\
        ///     &quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\
        ///     &quot;&gt;widget_read&lt;/a&gt; - Required when agreementAssetId refers to a widget&lt;/li&gt;&lt;li style&#x3D;
        ///     &#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot;
        ///     target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt; - Required when agreementAssetId refers to a library
        ///     document&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick
        ///     &#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;
        ///     oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - In addition to
        ///     one of the above scopes, this scope is required if the user wants to generate a URL that will automatically log the
        ///     user in.&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementAssetRequest">Information about the type of url to be generated for Agreement Asset Page</param>
        /// <param name="xUserId">The ID of the user for whom URL is being generated.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user for whom URL is being generated. If both X-User-Id and
        ///     X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <returns>ViewUrl</returns>
        public ViewUrl CreateAgreementAssetUrl(string accessToken, AgreementAssetRequest agreementAssetRequest, string xUserId, string xUserEmail)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateAgreementAssetUrl");

            // verify the required parameter 'agreementAssetRequest' is set
            if (agreementAssetRequest == null) throw new ApiException(400, "Missing required parameter 'agreementAssetRequest' when calling CreateAgreementAssetUrl");


            string path = "/views/agreementAssets";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xUserId != null) headerParams.Add("x-user-id", ApiClient.ParameterToString(xUserId)); // header parameter
            if (xUserEmail != null) headerParams.Add("x-user-email", ApiClient.ParameterToString(xUserEmail)); // header parameter
            postBody = ApiClient.Serialize(agreementAssetRequest); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling CreateAgreementAssetUrl: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling CreateAgreementAssetUrl: " + response.ErrorMessage, response.ErrorMessage);

            return (ViewUrl) ApiClient.Deserialize(response.Content, typeof(ViewUrl), response.Headers);
        }

        /// <summary>
        ///     Returns the URL for settings page. This endpoint will return the URL for Settings Page. The settings page can be of
        ///     two types - user profile page(for non admin) and account settings page(for admin). If the user wants to generate a
        ///     URL that will automatically log the user in then user_login scope is required in the given Oauth Access Token.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href
        ///     &#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - If the
        ///     user wants to generate a URL that will automatically log the user in then this  scope is required else any valid
        ///     scope can be used&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="targetViewRequest">Information about the type of url to be generated for various Settings page</param>
        /// <param name="xUserId">The ID of the user for whom URL is being generated.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user for whom URL is being generated. If both X-User-Id and
        ///     X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <returns>ViewUrl</returns>
        public ViewUrl CreateSettingsUrl(string accessToken, TargetViewRequest targetViewRequest, string xUserId, string xUserEmail)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateSettingsUrl");

            // verify the required parameter 'targetViewRequest' is set
            if (targetViewRequest == null) throw new ApiException(400, "Missing required parameter 'targetViewRequest' when calling CreateSettingsUrl");


            string path = "/views/settings";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xUserId != null) headerParams.Add("x-user-id", ApiClient.ParameterToString(xUserId)); // header parameter
            if (xUserEmail != null) headerParams.Add("x-user-email", ApiClient.ParameterToString(xUserEmail)); // header parameter
            postBody = ApiClient.Serialize(targetViewRequest); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling CreateSettingsUrl: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling CreateSettingsUrl: " + response.ErrorMessage, response.ErrorMessage);

            return (ViewUrl) ApiClient.Deserialize(response.Content, typeof(ViewUrl), response.Headers);
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