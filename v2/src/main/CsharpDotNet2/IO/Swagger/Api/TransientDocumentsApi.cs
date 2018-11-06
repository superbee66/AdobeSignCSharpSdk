using System.Collections.Generic;
using System.IO;
using AdobeSignClient.V2.Client;
using AdobeSignClient.V2.Model;
using RestSharp;

namespace AdobeSignClient.V2.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransientDocumentsApi
    {
        /// <summary>
        ///     Uploads a document and obtains the document&#39;s ID. The document uploaded through this call is referred to as
        ///     transient since it is available only for 7 days after the upload. The returned transient document ID can be used in
        ///     the API calls where the uploaded file needs to be referred. The transient document request is a multipart request
        ///     consisting of three parts - filename, mime type and the file stream. You can only upload one file at a time in this
        ///     request.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with any of the following scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a
        ///     href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\
        ///     &quot;&gt;agreement_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href
        ///     &#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu
        ///     &#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;
        ///     agreement_send&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;
        ///     &lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\
        ///     &quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;library_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;
        ///     (Legacy clients can use the access token obtained from /auth/tokens endpoint.)
        /// </param>
        /// <param name="file">The file part of the multipart request for document upload. You can upload only one file at a time.</param>
        /// <param name="fileName">
        ///     A name for the document being uploaded. Maximum number of characters in the name is restricted
        ///     to 255.
        /// </param>
        /// <param name="mimeType">
        ///     The mime type of the document being uploaded. If not specified here then mime type is picked up
        ///     from the file object. If mime type is not present there either then mime type is inferred from file name extension.
        /// </param>
        /// <returns>TransientDocumentResponse</returns>
        TransientDocumentResponse CreateTransientDocument(string accessToken, Stream file, string fileName, string mimeType);
    }

    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransientDocumentsApi : ITransientDocumentsApi
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TransientDocumentsApi" /> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransientDocumentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                ApiClient = Configuration.DefaultApiClient;
            else
                ApiClient = apiClient;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TransientDocumentsApi" /> class.
        /// </summary>
        /// <returns></returns>
        public TransientDocumentsApi(string basePath)
        {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        ///     Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///     Uploads a document and obtains the document&#39;s ID. The document uploaded through this call is referred to as
        ///     transient since it is available only for 7 days after the upload. The returned transient document ID can be used in
        ///     the API calls where the uploaded file needs to be referred. The transient document request is a multipart request
        ///     consisting of three parts - filename, mime type and the file stream. You can only upload one file at a time in this
        ///     request.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with any of the following scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a
        ///     href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\
        ///     &quot;&gt;agreement_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href
        ///     &#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu
        ///     &#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;
        ///     agreement_send&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;
        ///     &lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\
        ///     &quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(
        ///     &#39;library_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;
        ///     (Legacy clients can use the access token obtained from /auth/tokens endpoint.)
        /// </param>
        /// <param name="file">The file part of the multipart request for document upload. You can upload only one file at a time.</param>
        /// <param name="fileName">
        ///     A name for the document being uploaded. Maximum number of characters in the name is restricted
        ///     to 255.
        /// </param>
        /// <param name="mimeType">
        ///     The mime type of the document being uploaded. If not specified here then mime type is picked up
        ///     from the file object. If mime type is not present there either then mime type is inferred from file name extension.
        /// </param>
        /// <returns>TransientDocumentResponse</returns>
        public TransientDocumentResponse CreateTransientDocument(string accessToken, Stream file, string fileName, string mimeType)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateTransientDocument");

            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling CreateTransientDocument");


            string path = "/transientDocuments";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (fileName != null) formParams.Add("File-Name", ApiClient.ParameterToString(fileName)); // form parameter
            if (mimeType != null) formParams.Add("Mime-Type", ApiClient.ParameterToString(mimeType)); // form parameter
            if (file != null) fileParams.Add("File", ApiClient.ParameterToFile("File", file));

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling CreateTransientDocument: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling CreateTransientDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (TransientDocumentResponse) ApiClient.Deserialize(response.Content, typeof(TransientDocumentResponse), response.Headers);
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