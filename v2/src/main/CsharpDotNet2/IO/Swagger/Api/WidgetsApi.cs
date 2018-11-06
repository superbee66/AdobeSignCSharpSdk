using System;
using System.Collections.Generic;
using AdobeSignClient.V2.Client;
using AdobeSignClient.V2.Model;
using RestSharp;

namespace AdobeSignClient.V2.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWidgetsApi
    {
        /// <summary>
        /// Creates a widget and returns the Javascript snippet and URL to access the widget and widgetID in response to the client. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="widgetCreationRequest">Information about the widget that you want to create.</param>
        /// <param name="xUserId">The ID of the user on whose behalf widget is being created.</param>
        /// <param name="xUserEmail">The email address of the user on whose behalf widget is being created. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token.</param>
        /// <returns>WidgetCreationResponse</returns>
        WidgetCreationResponse CreateWidget (string accessToken, WidgetCreationRequest widgetCreationRequest, string xUserId, string xUserEmail);
        /// <summary>
        /// Retrieves agreements for the widget. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <returns>WidgetAgreements</returns>
        WidgetAgreements GetWidgetAgreements (string accessToken, string widgetId);
        /// <summary>
        /// Retrieves the audit trail of a widget identified by widgetId. PDF file stream containing audit trail information
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <returns>byte[]</returns>
        byte[] GetWidgetAuditTrail (string accessToken, string widgetId);
        /// <summary>
        /// Gets a single combined PDF document for the documents associated with a widget. A File Stream of combined PDF document
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="versionId">The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used.</param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param>
        /// <param name="auditReport">When set to YES, attach an audit report to the signed Widget PDF. Default value is false</param>
        /// <returns>byte[]</returns>
        byte[] GetWidgetCombinedDocument (string accessToken, string widgetId, string versionId, string participantEmail, bool? auditReport);
        /// <summary>
        /// Retrieves the file stream of a document of a widget. Raw stream of the file
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="documentId">The document identifier, as retrieved from the API which fetches the documents of a specified widget</param>
        /// <returns>byte[]</returns>
        byte[] GetWidgetDocumentInfo (string accessToken, string widgetId, string documentId);
        /// <summary>
        /// Retrieves the IDs of the documents associated with widget. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="versionId">The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used.</param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param>
        /// <returns>WidgetDocuments</returns>
        WidgetDocuments GetWidgetDocuments (string accessToken, string widgetId, string versionId, string participantEmail);
        /// <summary>
        /// Retrieves data entered by the user into interactive form fields at the time they signed the widget CSV file stream containing form data information
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <returns>byte[]</returns>
        byte[] GetWidgetFormData (string accessToken, string widgetId);
        /// <summary>
        /// Retrieves the details of a widget. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <returns>WidgetInfo</returns>
        WidgetInfo GetWidgetInfo (string accessToken, string widgetId);
        /// <summary>
        /// Retrieves widgets for a user. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="xUserId">The ID of the user whose widgets are being requested.</param>
        /// <param name="xUserEmail">The email address of the user whose widgets are being requested. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token.</param>
        /// <returns>UserWidgets</returns>
        UserWidgets GetWidgets (string accessToken, string xUserId, string xUserEmail);
        /// <summary>
        /// Personalize the widget to a signable document for a specific known user 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="widgetPersonalizationInfo">Widget Personalize update information object</param>
        /// <returns>WidgetPersonalizeResponse</returns>
        WidgetPersonalizeResponse UpdateWidgetPersonalize (string accessToken, string widgetId, WidgetPersonalizationInfo widgetPersonalizationInfo);
        /// <summary>
        /// Enables or Disables a widget. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param>
        /// <param name="widgetStatusUpdateInfo">Widget status update information object.</param>
        /// <returns>WidgetStatusUpdateResponse</returns>
        WidgetStatusUpdateResponse UpdateWidgetStatus (string accessToken, string widgetId, WidgetStatusUpdateInfo widgetStatusUpdateInfo);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WidgetsApi : IWidgetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WidgetsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WidgetsApi(String basePath)
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
        /// Creates a widget and returns the Javascript snippet and URL to access the widget and widgetID in response to the client. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="widgetCreationRequest">Information about the widget that you want to create.</param> 
        /// <param name="xUserId">The ID of the user on whose behalf widget is being created.</param> 
        /// <param name="xUserEmail">The email address of the user on whose behalf widget is being created. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token.</param> 
        /// <returns>WidgetCreationResponse</returns>            
        public WidgetCreationResponse CreateWidget (string accessToken, WidgetCreationRequest widgetCreationRequest, string xUserId, string xUserEmail)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateWidget");
            
            // verify the required parameter 'widgetCreationRequest' is set
            if (widgetCreationRequest == null) throw new ApiException(400, "Missing required parameter 'widgetCreationRequest' when calling CreateWidget");
            
    
            var path = "/widgets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
 if (xUserId != null) headerParams.Add("x-user-id", ApiClient.ParameterToString(xUserId)); // header parameter
 if (xUserEmail != null) headerParams.Add("x-user-email", ApiClient.ParameterToString(xUserEmail)); // header parameter
                        postBody = ApiClient.Serialize(widgetCreationRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateWidget: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateWidget: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetCreationResponse) ApiClient.Deserialize(response.Content, typeof(WidgetCreationResponse), response.Headers);
        }
    
        /// <summary>
        /// Retrieves agreements for the widget. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <returns>WidgetAgreements</returns>            
        public WidgetAgreements GetWidgetAgreements (string accessToken, string widgetId)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetWidgetAgreements");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetAgreements");
            
    
            var path = "/widgets/{widgetId}/agreements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetAgreements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetAgreements: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetAgreements) ApiClient.Deserialize(response.Content, typeof(WidgetAgreements), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the audit trail of a widget identified by widgetId. PDF file stream containing audit trail information
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetWidgetAuditTrail (string accessToken, string widgetId)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetWidgetAuditTrail");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetAuditTrail");
            
    
            var path = "/widgets/{widgetId}/auditTrail";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetAuditTrail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetAuditTrail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Gets a single combined PDF document for the documents associated with a widget. A File Stream of combined PDF document
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="versionId">The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used.</param> 
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param> 
        /// <param name="auditReport">When set to YES, attach an audit report to the signed Widget PDF. Default value is false</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetWidgetCombinedDocument (string accessToken, string widgetId, string versionId, string participantEmail, bool? auditReport)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetWidgetCombinedDocument");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetCombinedDocument");
            
    
            var path = "/widgets/{widgetId}/combinedDocument";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
 if (participantEmail != null) queryParams.Add("participantEmail", ApiClient.ParameterToString(participantEmail)); // query parameter
 if (auditReport != null) queryParams.Add("auditReport", ApiClient.ParameterToString(auditReport)); // query parameter
             if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetCombinedDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetCombinedDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the file stream of a document of a widget. Raw stream of the file
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="documentId">The document identifier, as retrieved from the API which fetches the documents of a specified widget</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetWidgetDocumentInfo (string accessToken, string widgetId, string documentId)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetWidgetDocumentInfo");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetDocumentInfo");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetWidgetDocumentInfo");
            
    
            var path = "/widgets/{widgetId}/documents/{documentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
path = path.Replace("{" + "documentId" + "}", ApiClient.ParameterToString(documentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetDocumentInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetDocumentInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the IDs of the documents associated with widget. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="versionId">The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used.</param> 
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param> 
        /// <returns>WidgetDocuments</returns>            
        public WidgetDocuments GetWidgetDocuments (string accessToken, string widgetId, string versionId, string participantEmail)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetWidgetDocuments");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetDocuments");
            
    
            var path = "/widgets/{widgetId}/documents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
 if (participantEmail != null) queryParams.Add("participantEmail", ApiClient.ParameterToString(participantEmail)); // query parameter
             if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetDocuments) ApiClient.Deserialize(response.Content, typeof(WidgetDocuments), response.Headers);
        }
    
        /// <summary>
        /// Retrieves data entered by the user into interactive form fields at the time they signed the widget CSV file stream containing form data information
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetWidgetFormData (string accessToken, string widgetId)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetWidgetFormData");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetFormData");
            
    
            var path = "/widgets/{widgetId}/formData";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetFormData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetFormData: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the details of a widget. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <returns>WidgetInfo</returns>            
        public WidgetInfo GetWidgetInfo (string accessToken, string widgetId)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetWidgetInfo");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling GetWidgetInfo");
            
    
            var path = "/widgets/{widgetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgetInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetInfo) ApiClient.Deserialize(response.Content, typeof(WidgetInfo), response.Headers);
        }
    
        /// <summary>
        /// Retrieves widgets for a user. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="xUserId">The ID of the user whose widgets are being requested.</param> 
        /// <param name="xUserEmail">The email address of the user whose widgets are being requested. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token.</param> 
        /// <returns>UserWidgets</returns>            
        public UserWidgets GetWidgets (string accessToken, string xUserId, string xUserEmail)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetWidgets");
            
    
            var path = "/widgets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
 if (xUserId != null) headerParams.Add("x-user-id", ApiClient.ParameterToString(xUserId)); // header parameter
 if (xUserEmail != null) headerParams.Add("x-user-email", ApiClient.ParameterToString(xUserEmail)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWidgets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserWidgets) ApiClient.Deserialize(response.Content, typeof(UserWidgets), response.Headers);
        }
    
        /// <summary>
        /// Personalize the widget to a signable document for a specific known user 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="widgetPersonalizationInfo">Widget Personalize update information object</param> 
        /// <returns>WidgetPersonalizeResponse</returns>            
        public WidgetPersonalizeResponse UpdateWidgetPersonalize (string accessToken, string widgetId, WidgetPersonalizationInfo widgetPersonalizationInfo)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling UpdateWidgetPersonalize");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling UpdateWidgetPersonalize");
            
            // verify the required parameter 'widgetPersonalizationInfo' is set
            if (widgetPersonalizationInfo == null) throw new ApiException(400, "Missing required parameter 'widgetPersonalizationInfo' when calling UpdateWidgetPersonalize");
            
    
            var path = "/widgets/{widgetId}/personalize";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                        postBody = ApiClient.Serialize(widgetPersonalizationInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidgetPersonalize: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidgetPersonalize: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetPersonalizeResponse) ApiClient.Deserialize(response.Content, typeof(WidgetPersonalizeResponse), response.Headers);
        }
    
        /// <summary>
        /// Enables or Disables a widget. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="widgetId">The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.</param> 
        /// <param name="widgetStatusUpdateInfo">Widget status update information object.</param> 
        /// <returns>WidgetStatusUpdateResponse</returns>            
        public WidgetStatusUpdateResponse UpdateWidgetStatus (string accessToken, string widgetId, WidgetStatusUpdateInfo widgetStatusUpdateInfo)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling UpdateWidgetStatus");
            
            // verify the required parameter 'widgetId' is set
            if (widgetId == null) throw new ApiException(400, "Missing required parameter 'widgetId' when calling UpdateWidgetStatus");
            
            // verify the required parameter 'widgetStatusUpdateInfo' is set
            if (widgetStatusUpdateInfo == null) throw new ApiException(400, "Missing required parameter 'widgetStatusUpdateInfo' when calling UpdateWidgetStatus");
            
    
            var path = "/widgets/{widgetId}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "widgetId" + "}", ApiClient.ParameterToString(widgetId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                        postBody = ApiClient.Serialize(widgetStatusUpdateInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidgetStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWidgetStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WidgetStatusUpdateResponse) ApiClient.Deserialize(response.Content, typeof(WidgetStatusUpdateResponse), response.Headers);
        }
    
    }
}
