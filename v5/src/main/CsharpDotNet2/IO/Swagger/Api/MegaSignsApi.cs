using System.Collections.Generic;
using AdobeSignClient.V5.Client;
using AdobeSignClient.V5.Model;
using RestSharp;

namespace AdobeSignClient.V5.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMegaSignsApi
    {
        /// <summary>
        ///     Send an agreement out for signature to multiple recipients. Each recipient will receive and sign their own copy of
        ///     the agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_send&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="megaSignCreationRequest">Information about the MegaSign that you want to send.</param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>MegaSignCreationResponse</returns>
        MegaSignCreationResponse CreateMegaSign(string accessToken, MegaSignCreationRequest megaSignCreationRequest, string xApiUser);

        /// <summary>
        ///     Get all the child agreements of the specified MegaSign parent agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="megaSignId">
        ///     The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or
        ///     retrieved from the API to fetch megaSign agreements
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>MegaSignChildAgreements</returns>
        MegaSignChildAgreements GetMegaSignChildAgreements(string accessToken, string megaSignId, string xApiUser);

        /// <summary>
        ///     Retrieves data entered by recipients into interactive form fields at the time they signed the child agreements of
        ///     the specified MegaSign agreement CSV file stream containing form data information
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="accept"> Specify media types which are acceptable for the response. Currently only text/csv is supported.</param>
        /// <param name="megaSignId">
        ///     The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or
        ///     retrieved from the API to fetch megaSign agreements
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>byte[]</returns>
        byte[] GetMegaSignFormData(string accessToken, string accept, string megaSignId, string xApiUser);

        /// <summary>
        ///     Get detailed information of the specified MegaSign parent agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="megaSignId">
        ///     The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or
        ///     retrieved from the API to fetch megaSign agreements
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>MegaSignInfo</returns>
        MegaSignInfo GetMegaSignInfo(string accessToken, string megaSignId, string xApiUser);

        /// <summary>
        ///     Get all the MegaSign parent agreements of a user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <param name="query">
        ///     The query string used for the search. Multiple search terms can be provided, separated by spaces.
        ///     Some of the search terms include document name, participant name or company, and form data
        /// </param>
        /// <returns>MegaSigns</returns>
        MegaSigns GetMegaSigns(string accessToken, string xApiUser, string query);

        /// <summary>
        ///     Cancel all the child agreements of the specified MegaSign agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;
        ///     /a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="megaSignId">
        ///     The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or
        ///     retrieved from the API to fetch megaSign agreements
        /// </param>
        /// <param name="megaSignStatusUpdateInfo">MegaSign status update information object.</param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>MegaSignStatusUpdateResponse</returns>
        MegaSignStatusUpdateResponse UpdateMegaSignStatus(string accessToken, string megaSignId, MegaSignStatusUpdateInfo megaSignStatusUpdateInfo, string xApiUser);
    }

    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MegaSignsApi : IMegaSignsApi
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MegaSignsApi" /> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MegaSignsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                ApiClient = Configuration.DefaultApiClient;
            else
                ApiClient = apiClient;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MegaSignsApi" /> class.
        /// </summary>
        /// <returns></returns>
        public MegaSignsApi(string basePath)
        {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        ///     Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///     Send an agreement out for signature to multiple recipients. Each recipient will receive and sign their own copy of
        ///     the agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_send&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="megaSignCreationRequest">Information about the MegaSign that you want to send.</param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>MegaSignCreationResponse</returns>
        public MegaSignCreationResponse CreateMegaSign(string accessToken, MegaSignCreationRequest megaSignCreationRequest, string xApiUser)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateMegaSign");

            // verify the required parameter 'megaSignCreationRequest' is set
            if (megaSignCreationRequest == null) throw new ApiException(400, "Missing required parameter 'megaSignCreationRequest' when calling CreateMegaSign");


            string path = "/megaSigns";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            postBody = ApiClient.Serialize(megaSignCreationRequest); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling CreateMegaSign: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling CreateMegaSign: " + response.ErrorMessage, response.ErrorMessage);

            return (MegaSignCreationResponse) ApiClient.Deserialize(response.Content, typeof(MegaSignCreationResponse), response.Headers);
        }

        /// <summary>
        ///     Get all the child agreements of the specified MegaSign parent agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="megaSignId">
        ///     The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or
        ///     retrieved from the API to fetch megaSign agreements
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>MegaSignChildAgreements</returns>
        public MegaSignChildAgreements GetMegaSignChildAgreements(string accessToken, string megaSignId, string xApiUser)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetMegaSignChildAgreements");

            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling GetMegaSignChildAgreements");


            string path = "/megaSigns/{megaSignId}/agreements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));

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
                throw new ApiException((int) response.StatusCode, "Error calling GetMegaSignChildAgreements: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetMegaSignChildAgreements: " + response.ErrorMessage, response.ErrorMessage);

            return (MegaSignChildAgreements) ApiClient.Deserialize(response.Content, typeof(MegaSignChildAgreements), response.Headers);
        }

        /// <summary>
        ///     Retrieves data entered by recipients into interactive form fields at the time they signed the child agreements of
        ///     the specified MegaSign agreement CSV file stream containing form data information
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="accept"> Specify media types which are acceptable for the response. Currently only text/csv is supported.</param>
        /// <param name="megaSignId">
        ///     The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or
        ///     retrieved from the API to fetch megaSign agreements
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>byte[]</returns>
        public byte[] GetMegaSignFormData(string accessToken, string accept, string megaSignId, string xApiUser)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetMegaSignFormData");

            // verify the required parameter 'accept' is set
            if (accept == null) throw new ApiException(400, "Missing required parameter 'accept' when calling GetMegaSignFormData");

            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling GetMegaSignFormData");


            string path = "/megaSigns/{megaSignId}/formData";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (accept != null) headerParams.Add("accept", ApiClient.ParameterToString(accept)); // header parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetMegaSignFormData: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetMegaSignFormData: " + response.ErrorMessage, response.ErrorMessage);

            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }

        /// <summary>
        ///     Get detailed information of the specified MegaSign parent agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="megaSignId">
        ///     The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or
        ///     retrieved from the API to fetch megaSign agreements
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>MegaSignInfo</returns>
        public MegaSignInfo GetMegaSignInfo(string accessToken, string megaSignId, string xApiUser)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetMegaSignInfo");

            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling GetMegaSignInfo");


            string path = "/megaSigns/{megaSignId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));

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
                throw new ApiException((int) response.StatusCode, "Error calling GetMegaSignInfo: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetMegaSignInfo: " + response.ErrorMessage, response.ErrorMessage);

            return (MegaSignInfo) ApiClient.Deserialize(response.Content, typeof(MegaSignInfo), response.Headers);
        }

        /// <summary>
        ///     Get all the MegaSign parent agreements of a user.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a
        ///     &gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <param name="query">
        ///     The query string used for the search. Multiple search terms can be provided, separated by spaces.
        ///     Some of the search terms include document name, participant name or company, and form data
        /// </param>
        /// <returns>MegaSigns</returns>
        public MegaSigns GetMegaSigns(string accessToken, string xApiUser, string query)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling GetMegaSigns");


            string path = "/megaSigns";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling GetMegaSigns: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling GetMegaSigns: " + response.ErrorMessage, response.ErrorMessage);

            return (MegaSigns) ApiClient.Deserialize(response.Content, typeof(MegaSigns), response.Headers);
        }

        /// <summary>
        ///     Cancel all the child agreements of the specified MegaSign agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;
        ///     /a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="megaSignId">
        ///     The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or
        ///     retrieved from the API to fetch megaSign agreements
        /// </param>
        /// <param name="megaSignStatusUpdateInfo">MegaSign status update information object.</param>
        /// <param name="xApiUser">
        ///     The userId or email of API caller using the account or group token in the format &lt;b&gt;
        ///     userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.
        /// </param>
        /// <returns>MegaSignStatusUpdateResponse</returns>
        public MegaSignStatusUpdateResponse UpdateMegaSignStatus(string accessToken, string megaSignId, MegaSignStatusUpdateInfo megaSignStatusUpdateInfo, string xApiUser)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling UpdateMegaSignStatus");

            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling UpdateMegaSignStatus");

            // verify the required parameter 'megaSignStatusUpdateInfo' is set
            if (megaSignStatusUpdateInfo == null) throw new ApiException(400, "Missing required parameter 'megaSignStatusUpdateInfo' when calling UpdateMegaSignStatus");


            string path = "/megaSigns/{megaSignId}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            postBody = ApiClient.Serialize(megaSignStatusUpdateInfo); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling UpdateMegaSignStatus: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling UpdateMegaSignStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (MegaSignStatusUpdateResponse) ApiClient.Deserialize(response.Content, typeof(MegaSignStatusUpdateResponse), response.Headers);
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