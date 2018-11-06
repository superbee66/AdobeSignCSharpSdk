# IO.Swagger.Api.RemindersApi

All URIs are relative to *https://secure.na1.echosign.com/api/rest/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateReminder**](RemindersApi.md#createreminder) | **POST** /reminders | Sends a reminder for an agreement.


<a name="createreminder"></a>
# **CreateReminder**
> ReminderCreationResult CreateReminder (string accessToken, ReminderCreationInfo reminderCreationInfo)

Sends a reminder for an agreement.

Sends a reminder for an agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateReminderExample
    {
        public void main()
        {
            
            var apiInstance = new RemindersApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_write')\" oncontextmenu=\"this.href=oauthDoc('agreement_write')\" target=\"oauthDoc\">agreement_write</a></li></ul>(Legacy clients can use the access token obtained from /auth/tokens endpoint.)
            var reminderCreationInfo = new ReminderCreationInfo(); // ReminderCreationInfo | Information about the reminder.

            try
            {
                // Sends a reminder for an agreement.
                ReminderCreationResult result = apiInstance.CreateReminder(accessToken, reminderCreationInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemindersApi.CreateReminder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.) | 
 **reminderCreationInfo** | [**ReminderCreationInfo**](ReminderCreationInfo.md)| Information about the reminder. | 

### Return type

[**ReminderCreationResult**](ReminderCreationResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

