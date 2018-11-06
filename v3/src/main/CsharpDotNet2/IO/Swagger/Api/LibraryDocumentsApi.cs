using System.Collections.Generic;
using AdobeSignClient.V3.Client;
using AdobeSignClient.V3.Model;
using RestSharp;

namespace AdobeSignClient.V3.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILibraryDocumentsApi
    {
        /// <summary>
        ///     Creates a template that is placed in the library of the user for reuse.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_write&lt;/a
        ///     &gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;
        ///     \&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - Required additionally if the
        ///     autoLoginUser parameter is set to true&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryCreationInfo">
        ///     Information about the library document that you want to create and authoring options
        ///     that you want to apply at the time of creation.
        /// </param>
        /// <param name="xUserId">The ID of the user on whose behalf library document is being created.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user on whose behalf library document is being created. If both
        ///     X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user
        ///     is inferred from the access token.
        /// </param>
        /// <returns>LibraryDocumentCreationResponse</returns>
        LibraryDocumentCreationResponse CreateLibraryDocument(string accessToken, LibraryCreationInfo libraryCreationInfo, string xUserId, string xUserEmail);

        /// <summary>
        ///     Retrieves the combined document associated with a library document. File Stream of PDF file
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param>
        /// <param name="auditReport">
        ///     When set to YES attach an audit report to the library document PDF. Default value will be
        ///     false.
        /// </param>
        /// <returns>byte[]</returns>
        byte[] GetCombinedDocument(string accessToken, string libraryDocumentId, bool? auditReport);

        /// <summary>
        ///     Retrieves the IDs of the documents associated with library document.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param>
        /// <returns>Documents</returns>
        Documents GetDocuments(string accessToken, string libraryDocumentId);

        /// <summary>
        ///     Retrieves the file stream of a document of library document. Raw stream of the file
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param>
        /// <param name="documentId">
        ///     The document identifier, as retrieved from the API which fetches the documents of a specified
        ///     library document
        /// </param>
        /// <returns>byte[]</returns>
        byte[] GetLibraryDocument(string accessToken, string libraryDocumentId, string documentId);

        /// <summary>
        ///     Retrieves the audit trail associated with a library document. File Stream of PDF file
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param>
        /// <returns>byte[]</returns>
        byte[] GetLibraryDocumentAuditTrail(string accessToken, string libraryDocumentId);

        /// <summary>
        ///     Retrieves the details of a library document.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param>
        /// <returns>LibraryDocumentInfo</returns>
        LibraryDocumentInfo GetLibraryDocumentInfo(string accessToken, string libraryDocumentId);

        /// <summary>
        ///     Retrieves library documents for a user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="xUserId">The ID of the user whose library documents are being requested.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user whose library documents are being requested. If both X-User-Id
        ///     and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <param name="libraryTemplateType">
        ///     The type of library template. It can have two possible values DOCUMENT or
        ///     FORM_FIELD_LAYER. If not specified all the library templates will be retrieved.
        /// </param>
        /// <returns>DocumentLibraryItems</returns>
        DocumentLibraryItems GetLibraryDocuments(string accessToken, string xUserId, string xUserEmail, string libraryTemplateType);
    }

    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LibraryDocumentsApi : ILibraryDocumentsApi
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LibraryDocumentsApi" /> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LibraryDocumentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                ApiClient = Configuration.DefaultApiClient;
            else
                ApiClient = apiClient;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="LibraryDocumentsApi" /> class.
        /// </summary>
        /// <returns></returns>
        public LibraryDocumentsApi(string basePath)
        {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        ///     Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///     Creates a template that is placed in the library of the user for reuse.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_write&lt;/a
        ///     &gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;
        ///     \&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;
        ///     user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - Required additionally if the
        ///     autoLoginUser parameter is set to true&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryCreationInfo">
        ///     Information about the library document that you want to create and authoring options
        ///     that you want to apply at the time of creation.
        /// </param>
        /// <param name="xUserId">The ID of the user on whose behalf library document is being created.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user on whose behalf library document is being created. If both
        ///     X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user
        ///     is inferred from the access token.
        /// </param>
        /// <returns>LibraryDocumentCreationResponse</returns>
        public LibraryDocumentCreationResponse CreateLibraryDocument(string accessToken, LibraryCreationInfo libraryCreationInfo, string xUserId, string xUserEmail)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateLibraryDocument");

            // verify the required parameter 'libraryCreationInfo' is set
            if (libraryCreationInfo == null) throw new ApiException(400, "Missing required parameter 'libraryCreationInfo' when calling CreateLibraryDocument");


            string path = "/libraryDocuments";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xUserId != null) headerParams.Add("x-user-id", ApiClient.ParameterToString(xUserId)); // header parameter
            if (xUserEmail != null) headerParams.Add("x-user-email", ApiClient.ParameterToString(xUserEmail)); // header parameter
            postBody = ApiClient.Serialize(libraryCreationInfo); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling CreateLibraryDocument: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling CreateLibraryDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (LibraryDocumentCreationResponse) ApiClient.Deserialize(response.Content, typeof(LibraryDocumentCreationResponse), response.Headers);
        }

        /// <summary>
        ///     Retrieves the combined document associated with a library document. File Stream of PDF file
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param>
        /// <param name="auditReport">
        ///     When set to YES attach an audit report to the library document PDF. Default value will be
        ///     false.
        /// </param>
        /// <returns>byte[]</returns>
        public byte[] GetCombinedDocument(string accessToken, string libraryDocumentId, bool? auditReport)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetCombinedDocument");

            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetCombinedDocument");


            string path = "/libraryDocuments/{libraryDocumentId}/combinedDocument";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (auditReport != null) queryParams.Add("auditReport", ApiClient.ParameterToString(auditReport)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetCombinedDocument: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetCombinedDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }

        /// <summary>
        ///     Retrieves the IDs of the documents associated with library document.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param>
        /// <returns>Documents</returns>
        public Documents GetDocuments(string accessToken, string libraryDocumentId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetDocuments");

            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetDocuments");


            string path = "/libraryDocuments/{libraryDocumentId}/documents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

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
                throw new ApiException((int) response.StatusCode, "Error calling GetDocuments: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return (Documents) ApiClient.Deserialize(response.Content, typeof(Documents), response.Headers);
        }

        /// <summary>
        ///     Retrieves the file stream of a document of library document. Raw stream of the file
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param>
        /// <param name="documentId">
        ///     The document identifier, as retrieved from the API which fetches the documents of a specified
        ///     library document
        /// </param>
        /// <returns>byte[]</returns>
        public byte[] GetLibraryDocument(string accessToken, string libraryDocumentId, string documentId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetLibraryDocument");

            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetLibraryDocument");

            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetLibraryDocument");


            string path = "/libraryDocuments/{libraryDocumentId}/documents/{documentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));
            path = path.Replace("{" + "documentId" + "}", ApiClient.ParameterToString(documentId));

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
                throw new ApiException((int) response.StatusCode, "Error calling GetLibraryDocument: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetLibraryDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }

        /// <summary>
        ///     Retrieves the audit trail associated with a library document. File Stream of PDF file
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param>
        /// <returns>byte[]</returns>
        public byte[] GetLibraryDocumentAuditTrail(string accessToken, string libraryDocumentId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetLibraryDocumentAuditTrail");

            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetLibraryDocumentAuditTrail");


            string path = "/libraryDocuments/{libraryDocumentId}/auditTrail";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

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
                throw new ApiException((int) response.StatusCode, "Error calling GetLibraryDocumentAuditTrail: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetLibraryDocumentAuditTrail: " + response.ErrorMessage, response.ErrorMessage);

            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }

        /// <summary>
        ///     Retrieves the details of a library document.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param>
        /// <returns>LibraryDocumentInfo</returns>
        public LibraryDocumentInfo GetLibraryDocumentInfo(string accessToken, string libraryDocumentId)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetLibraryDocumentInfo");

            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetLibraryDocumentInfo");


            string path = "/libraryDocuments/{libraryDocumentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

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
                throw new ApiException((int) response.StatusCode, "Error calling GetLibraryDocumentInfo: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetLibraryDocumentInfo: " + response.ErrorMessage, response.ErrorMessage);

            return (LibraryDocumentInfo) ApiClient.Deserialize(response.Content, typeof(LibraryDocumentInfo), response.Headers);
        }

        /// <summary>
        ///     Retrieves library documents for a user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;
        ///     &lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="xUserId">The ID of the user whose library documents are being requested.</param>
        /// <param name="xUserEmail">
        ///     The email address of the user whose library documents are being requested. If both X-User-Id
        ///     and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred
        ///     from the access token.
        /// </param>
        /// <param name="libraryTemplateType">
        ///     The type of library template. It can have two possible values DOCUMENT or
        ///     FORM_FIELD_LAYER. If not specified all the library templates will be retrieved.
        /// </param>
        /// <returns>DocumentLibraryItems</returns>
        public DocumentLibraryItems GetLibraryDocuments(string accessToken, string xUserId, string xUserEmail, string libraryTemplateType)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetLibraryDocuments");


            string path = "/libraryDocuments";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (libraryTemplateType != null) queryParams.Add("libraryTemplateType", ApiClient.ParameterToString(libraryTemplateType)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xUserId != null) headerParams.Add("x-user-id", ApiClient.ParameterToString(xUserId)); // header parameter
            if (xUserEmail != null) headerParams.Add("x-user-email", ApiClient.ParameterToString(xUserEmail)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetLibraryDocuments: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetLibraryDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return (DocumentLibraryItems) ApiClient.Deserialize(response.Content, typeof(DocumentLibraryItems), response.Headers);
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