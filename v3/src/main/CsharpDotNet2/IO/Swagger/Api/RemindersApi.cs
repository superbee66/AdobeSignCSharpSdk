using System.Collections.Generic;
using AdobeSignClient.V3.Client;
using AdobeSignClient.V3.Model;
using RestSharp;

namespace AdobeSignClient.V3.Api
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRemindersApi
    {
        /// <summary>
        ///     Sends a reminder for an agreement. Sends a reminder for an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;
        ///     /a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="reminderCreationInfo">Information about the reminder.</param>
        /// <returns>ReminderCreationResult</returns>
        ReminderCreationResult CreateReminder(string accessToken, ReminderCreationInfo reminderCreationInfo);
    }

    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RemindersApi : IRemindersApi
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RemindersApi" /> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RemindersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                ApiClient = Configuration.DefaultApiClient;
            else
                ApiClient = apiClient;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RemindersApi" /> class.
        /// </summary>
        /// <returns></returns>
        public RemindersApi(string basePath)
        {
            ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        ///     Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///     Sends a reminder for an agreement. Sends a reminder for an agreement.
        /// </summary>
        /// <param name="accessToken">
        ///     An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot;
        ///     oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token
        ///     &lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\
        ///     &quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;
        ///     this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;
        ///     /a&gt;&lt;/li&gt;&lt;/ul&gt;
        /// </param>
        /// <param name="reminderCreationInfo">Information about the reminder.</param>
        /// <returns>ReminderCreationResult</returns>
        public ReminderCreationResult CreateReminder(string accessToken, ReminderCreationInfo reminderCreationInfo)
        {
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling CreateReminder");

            // verify the required parameter 'reminderCreationInfo' is set
            if (reminderCreationInfo == null) throw new ApiException(400, "Missing required parameter 'reminderCreationInfo' when calling CreateReminder");


            string path = "/reminders";
            path = path.Replace("{format}", "json");

            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            Dictionary<string, string> headerParams = new Dictionary<string, string>();
            Dictionary<string, string> formParams = new Dictionary<string, string>();
            Dictionary<string, FileParameter> fileParams = new Dictionary<string, FileParameter>();
            string postBody = null;

            if (accessToken != null) headerParams.Add("Access-Token", ApiClient.ParameterToString(accessToken)); // header parameter
            postBody = ApiClient.Serialize(reminderCreationInfo); // http body (model) parameter

            // authentication setting, if any
            string[] authSettings = { };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if ((int) response.StatusCode >= 400)
                throw new ApiException((int) response.StatusCode, "Error calling CreateReminder: " + response.Content, response.Content);
            if ((int) response.StatusCode == 0)
                throw new ApiException((int) response.StatusCode, "Error calling CreateReminder: " + response.ErrorMessage, response.ErrorMessage);

            return (ReminderCreationResult) ApiClient.Deserialize(response.Content, typeof(ReminderCreationResult), response.Headers);
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