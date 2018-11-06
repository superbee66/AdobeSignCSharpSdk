using System.Collections.Generic;
using AdobeSignClient.V5.Client;
using AdobeSignClient.V5.Model;
using RestSharp;

namespace AdobeSignClient.V5.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApi
    {
        /// <summary>
        ///     Create a search object for agreement asset event . It will return the result for the first page and search Id to
        ///     fetch results for further pages. The agreement asset refers to any asset through which an agreement can be created
        ///     for instance library document,widget and agreement itself. To search for Agreement Asset Events, first make a
        ///     request to the API that creates agreementAssetEvents with relevant search parameters. Response will be the first
        ///     page of results along with a search Id param and next page cursor. These can be used to fetch further page results
        ///     if they are  available using the API which retrieves agreementAssetEvents based on searchId
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;
        ///     \&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;li style
        ///     &#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;
        ///     oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\
        ///     &quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementAssetEventRequest">Information about the Agreement Asset Events to be generated</param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>AgreementAssetEventPostResponse</returns>
        AgreementAssetEventPostResponse CreateAssetEvent(string accessToken, AgreementAssetEventRequest agreementAssetEventRequest, string xApiUser);

        /// <summary>
        ///     Return the result for the page which is described inside the Page Cursor Info. The agreement asset refers to any
        ///     asset through which an agreement can be created for instance library document,widget and agreement itself. Provide
        ///     the searchId obtained from the API that creates agreementAssetEvents and the next page cursor id from the original
        ///     call to the API that creates agreementAssetEvents or a previous call to the API that retrieves agreementAssetEvents
        ///     based on searchId.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;
        ///     \&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;li style
        ///     &#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;
        ///     oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\
        ///     &quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="searchId">The search object identifier, as returned by the agreementAssetEvent creation API .</param>
        /// <param name="pageCursor">Page cursor of the page whose result will be fetched</param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <param name="pageSize">
        ///     Count of agreement asset events which will be returned in the response. If the pageSize is left
        ///     blank, then the pageSize which is mentioned while making POST request to /search/agreementAssetEvents will be used.
        ///     Maximum page size is 500.
        /// </param>
        /// <returns>AgreementAssetEventGetResponse</returns>
        AgreementAssetEventGetResponse GetAssetEvent(string accessToken, string searchId, string pageCursor, string xApiUser, int? pageSize);
    }

    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SearchApi : ISearchApi
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SearchApi" /> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SearchApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                ApiClient = Configuration.DefaultApiClient;
            else
                ApiClient = apiClient;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SearchApi" /> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(string basePath)
        {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        ///     Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///     Create a search object for agreement asset event . It will return the result for the first page and search Id to
        ///     fetch results for further pages. The agreement asset refers to any asset through which an agreement can be created
        ///     for instance library document,widget and agreement itself. To search for Agreement Asset Events, first make a
        ///     request to the API that creates agreementAssetEvents with relevant search parameters. Response will be the first
        ///     page of results along with a search Id param and next page cursor. These can be used to fetch further page results
        ///     if they are  available using the API which retrieves agreementAssetEvents based on searchId
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;
        ///     \&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;li style
        ///     &#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;
        ///     oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\
        ///     &quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="agreementAssetEventRequest">Information about the Agreement Asset Events to be generated</param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>AgreementAssetEventPostResponse</returns>
        public AgreementAssetEventPostResponse CreateAssetEvent(string accessToken, AgreementAssetEventRequest agreementAssetEventRequest, string xApiUser)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateAssetEvent");

            // verify the required parameter 'agreementAssetEventRequest' is set
            if (agreementAssetEventRequest == null) throw new ApiException(400, "Missing required parameter 'agreementAssetEventRequest' when calling CreateAssetEvent");


            string path = "/search/agreementAssetEvents";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            postBody = ApiClient.Serialize(agreementAssetEventRequest); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling CreateAssetEvent: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling CreateAssetEvent: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementAssetEventPostResponse) ApiClient.Deserialize(response.Content, typeof(AgreementAssetEventPostResponse), response.Headers);
        }

        /// <summary>
        ///     Return the result for the page which is described inside the Page Cursor Info. The agreement asset refers to any
        ///     asset through which an agreement can be created for instance library document,widget and agreement itself. Provide
        ///     the searchId obtained from the API that creates agreementAssetEvents and the next page cursor id from the original
        ///     call to the API that creates agreementAssetEvents or a previous call to the API that retrieves agreementAssetEvents
        ///     based on searchId.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;
        ///     \&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;li style
        ///     &#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;
        ///     oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\
        ///     &quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="searchId">The search object identifier, as returned by the agreementAssetEvent creation API .</param>
        /// <param name="pageCursor">Page cursor of the page whose result will be fetched</param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <param name="pageSize">
        ///     Count of agreement asset events which will be returned in the response. If the pageSize is left
        ///     blank, then the pageSize which is mentioned while making POST request to /search/agreementAssetEvents will be used.
        ///     Maximum page size is 500.
        /// </param>
        /// <returns>AgreementAssetEventGetResponse</returns>
        public AgreementAssetEventGetResponse GetAssetEvent(string accessToken, string searchId, string pageCursor, string xApiUser, int? pageSize)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetAssetEvent");

            // verify the required parameter 'searchId' is set
            if (searchId == null) throw new ApiException(400, "Missing required parameter 'searchId' when calling GetAssetEvent");

            // verify the required parameter 'pageCursor' is set
            if (pageCursor == null) throw new ApiException(400, "Missing required parameter 'pageCursor' when calling GetAssetEvent");


            string path = "/search/agreementAssetEvents/{searchId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "searchId" + "}", ApiClient.ParameterToString(searchId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (pageCursor != null) queryParams.Add("pageCursor", ApiClient.ParameterToString(pageCursor)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetAssetEvent: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetAssetEvent: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementAssetEventGetResponse) ApiClient.Deserialize(response.Content, typeof(AgreementAssetEventGetResponse), response.Headers);
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