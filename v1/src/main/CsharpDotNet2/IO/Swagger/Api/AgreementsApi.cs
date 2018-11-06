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
    public interface IAgreementsApi
    {
        /// <summary>
        /// Creates an agreement. Sends it out for signatures, and returns the agreementID in the response to the client. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_send&lt;/a&gt; - If both authoringRequested and sendThroughWeb parameter are set to false&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt; - If any of the authoringRequested or sendThroughWeb parameter is set to true&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - Required additionally if the autoLoginUser parameter is set to true&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="agreementCreationInfo">Information about the agreement that you want to send and authoring options that you want to apply at the time of sending.</param>
        /// <param name="xUserId">The ID of the user on whose behalf agreement is being created.</param>
        /// <param name="xUserEmail">The email address of the user on whose behalf agreement is being created. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token.</param>
        /// <returns>AgreementCreationResponse</returns>
        AgreementCreationResponse CreateAgreement (string accessToken, AgreementCreationInfo agreementCreationInfo, string xUserId, string xUserEmail);
        /// <summary>
        /// Retrieves the current status of an agreement. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param>
        /// <returns>AgreementInfo</returns>
        AgreementInfo GetAgreementInfo (string accessToken, string agreementId);
        /// <summary>
        /// Retrieves agreements for the user. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="xUserId">The ID of the user whose agreements are being requested.</param>
        /// <param name="xUserEmail">The email address of the user whose agreements are being requested. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token.</param>
        /// <returns>UserAgreements</returns>
        UserAgreements GetAgreements (string accessToken, string xUserId, string xUserEmail);
        /// <summary>
        /// Retrieves the IDs of the documents of an agreement identified by agreementId. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param>
        /// <param name="versionId">The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used.</param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param>
        /// <param name="supportingDocumentContentFormat">Content format of the supported documents. It can have two possible values ORIGINAL or CONVERTED_PDF. Default value is CONVERTED_PDF.</param>
        /// <returns>AgreementDocuments</returns>
        AgreementDocuments GetAllDocuments (string accessToken, string agreementId, string versionId, string participantEmail, string supportingDocumentContentFormat);
        /// <summary>
        /// Retrieves the audit trail of an agreement identified by agreementId. PDF file stream containing audit trail information
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param>
        /// <returns>byte[]</returns>
        byte[] GetAuditTrail (string accessToken, string agreementId);
        /// <summary>
        /// Gets a single combined PDF document for the documents associated with an agreement. A File Stream of combined PDF document
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param>
        /// <param name="versionId">The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used.</param>
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param>
        /// <param name="attachSupportingDocuments">When set to true, attach corresponding supporting documents to the signed agreement PDF. Default value of this parameter is true.</param>
        /// <param name="auditReport">When set to true, attach an audit report to the signed agreement PDF. Default value is false</param>
        /// <returns>byte[]</returns>
        byte[] GetCombinedDocument (string accessToken, string agreementId, string versionId, string participantEmail, bool? attachSupportingDocuments, bool? auditReport);
        /// <summary>
        /// Retrieves the file stream of a document of an agreement. Raw stream of the file
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param>
        /// <param name="documentId">The document identifier, as retrieved from the API which fetches the documents of a specified agreement</param>
        /// <returns>byte[]</returns>
        byte[] GetDocument (string accessToken, string agreementId, string documentId);
        /// <summary>
        /// Cancels an agreement. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param>
        /// <param name="agreementStatusUpdateInfo">Agreement status update information object.</param>
        /// <returns>AgreementStatusUpdateResponse</returns>
        AgreementStatusUpdateResponse UpdateStatus (string accessToken, string agreementId, AgreementStatusUpdateInfo agreementStatusUpdateInfo);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AgreementsApi : IAgreementsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AgreementsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AgreementsApi(String basePath)
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
        /// Creates an agreement. Sends it out for signatures, and returns the agreementID in the response to the client. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_send&lt;/a&gt; - If both authoringRequested and sendThroughWeb parameter are set to false&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt; - If any of the authoringRequested or sendThroughWeb parameter is set to true&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - Required additionally if the autoLoginUser parameter is set to true&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="agreementCreationInfo">Information about the agreement that you want to send and authoring options that you want to apply at the time of sending.</param> 
        /// <param name="xUserId">The ID of the user on whose behalf agreement is being created.</param> 
        /// <param name="xUserEmail">The email address of the user on whose behalf agreement is being created. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token.</param> 
        /// <returns>AgreementCreationResponse</returns>            
        public AgreementCreationResponse CreateAgreement (string accessToken, AgreementCreationInfo agreementCreationInfo, string xUserId, string xUserEmail)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateAgreement");
            
            // verify the required parameter 'agreementCreationInfo' is set
            if (agreementCreationInfo == null) throw new ApiException(400, "Missing required parameter 'agreementCreationInfo' when calling CreateAgreement");
            
    
            var path = "/agreements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
 if (xUserId != null) headerParams.Add("x-user-id", ApiClient.ParameterToString(xUserId)); // header parameter
 if (xUserEmail != null) headerParams.Add("x-user-email", ApiClient.ParameterToString(xUserEmail)); // header parameter
                        postBody = ApiClient.Serialize(agreementCreationInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAgreement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAgreement: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AgreementCreationResponse) ApiClient.Deserialize(response.Content, typeof(AgreementCreationResponse), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the current status of an agreement. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <returns>AgreementInfo</returns>            
        public AgreementInfo GetAgreementInfo (string accessToken, string agreementId)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetAgreementInfo");
            
            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAgreementInfo");
            
    
            var path = "/agreements/{agreementId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAgreementInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAgreementInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AgreementInfo) ApiClient.Deserialize(response.Content, typeof(AgreementInfo), response.Headers);
        }
    
        /// <summary>
        /// Retrieves agreements for the user. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="xUserId">The ID of the user whose agreements are being requested.</param> 
        /// <param name="xUserEmail">The email address of the user whose agreements are being requested. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token.</param> 
        /// <returns>UserAgreements</returns>            
        public UserAgreements GetAgreements (string accessToken, string xUserId, string xUserEmail)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetAgreements");
            
    
            var path = "/agreements";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAgreements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAgreements: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserAgreements) ApiClient.Deserialize(response.Content, typeof(UserAgreements), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the IDs of the documents of an agreement identified by agreementId. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="versionId">The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used.</param> 
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param> 
        /// <param name="supportingDocumentContentFormat">Content format of the supported documents. It can have two possible values ORIGINAL or CONVERTED_PDF. Default value is CONVERTED_PDF.</param> 
        /// <returns>AgreementDocuments</returns>            
        public AgreementDocuments GetAllDocuments (string accessToken, string agreementId, string versionId, string participantEmail, string supportingDocumentContentFormat)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetAllDocuments");
            
            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAllDocuments");
            
    
            var path = "/agreements/{agreementId}/documents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
 if (participantEmail != null) queryParams.Add("participantEmail", ApiClient.ParameterToString(participantEmail)); // query parameter
 if (supportingDocumentContentFormat != null) queryParams.Add("supportingDocumentContentFormat", ApiClient.ParameterToString(supportingDocumentContentFormat)); // query parameter
             if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AgreementDocuments) ApiClient.Deserialize(response.Content, typeof(AgreementDocuments), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the audit trail of an agreement identified by agreementId. PDF file stream containing audit trail information
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetAuditTrail (string accessToken, string agreementId)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetAuditTrail");
            
            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAuditTrail");
            
    
            var path = "/agreements/{agreementId}/auditTrail";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuditTrail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAuditTrail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Gets a single combined PDF document for the documents associated with an agreement. A File Stream of combined PDF document
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="versionId">The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used.</param> 
        /// <param name="participantEmail">The email address of the participant to be used to retrieve documents.</param> 
        /// <param name="attachSupportingDocuments">When set to true, attach corresponding supporting documents to the signed agreement PDF. Default value of this parameter is true.</param> 
        /// <param name="auditReport">When set to true, attach an audit report to the signed agreement PDF. Default value is false</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetCombinedDocument (string accessToken, string agreementId, string versionId, string participantEmail, bool? attachSupportingDocuments, bool? auditReport)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetCombinedDocument");
            
            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetCombinedDocument");
            
    
            var path = "/agreements/{agreementId}/combinedDocument";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
 if (participantEmail != null) queryParams.Add("participantEmail", ApiClient.ParameterToString(participantEmail)); // query parameter
 if (attachSupportingDocuments != null) queryParams.Add("attachSupportingDocuments", ApiClient.ParameterToString(attachSupportingDocuments)); // query parameter
 if (auditReport != null) queryParams.Add("auditReport", ApiClient.ParameterToString(auditReport)); // query parameter
             if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCombinedDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCombinedDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the file stream of a document of an agreement. Raw stream of the file
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="documentId">The document identifier, as retrieved from the API which fetches the documents of a specified agreement</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetDocument (string accessToken, string agreementId, string documentId)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetDocument");
            
            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetDocument");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocument");
            
    
            var path = "/agreements/{agreementId}/documents/{documentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Cancels an agreement. 
        /// </summary>
        /// <param name="accessToken">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.)</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="agreementStatusUpdateInfo">Agreement status update information object.</param> 
        /// <returns>AgreementStatusUpdateResponse</returns>            
        public AgreementStatusUpdateResponse UpdateStatus (string accessToken, string agreementId, AgreementStatusUpdateInfo agreementStatusUpdateInfo)
        {
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling UpdateStatus");
            
            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling UpdateStatus");
            
            // verify the required parameter 'agreementStatusUpdateInfo' is set
            if (agreementStatusUpdateInfo == null) throw new ApiException(400, "Missing required parameter 'agreementStatusUpdateInfo' when calling UpdateStatus");
            
    
            var path = "/agreements/{agreementId}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
                        postBody = ApiClient.Serialize(agreementStatusUpdateInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AgreementStatusUpdateResponse) ApiClient.Deserialize(response.Content, typeof(AgreementStatusUpdateResponse), response.Headers);
        }
    
    }
}
