# IO.Swagger.Api.WorkflowsApi

All URIs are relative to *https://secure.na1.echosign.com/api/rest/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWorkflowAgreement**](WorkflowsApi.md#createworkflowagreement) | **POST** /workflows/{workflowId}/agreements | Creates an agreement. Sends it out for signatures, and returns the agreementId in the response to the client.
[**GetWorkflowInfo**](WorkflowsApi.md#getworkflowinfo) | **GET** /workflows/{workflowId} | Retrieves the details of a workflow.
[**GetWorkflows**](WorkflowsApi.md#getworkflows) | **GET** /workflows | Retrieves workflows for a user.


<a name="createworkflowagreement"></a>
# **CreateWorkflowAgreement**
> AgreementCreationResponse CreateWorkflowAgreement (string accessToken, string workflowId, CustomWorkflowAgreementCreationRequest customWorkflowAgreementCreationRequest, string xUserId, string xUserEmail)

Creates an agreement. Sends it out for signatures, and returns the agreementId in the response to the client.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateWorkflowAgreementExample
    {
        public void main()
        {
            
            var apiInstance = new WorkflowsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('workflow_read')\" oncontextmenu=\"this.href=oauthDoc('workflow_read')\" target=\"oauthDoc\">workflow_read</a> - To read the workflow resource which will be used for agreement creation</li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_send')\" oncontextmenu=\"this.href=oauthDoc('agreement_send')\" target=\"oauthDoc\">agreement_send</a> - If authoringRequested parameter is set to false</li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_write')\" oncontextmenu=\"this.href=oauthDoc('agreement_write')\" target=\"oauthDoc\">agreement_write</a> - If authoringRequested parameter is set to true</li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('user_login')\" oncontextmenu=\"this.href=oauthDoc('user_login')\" target=\"oauthDoc\">user_login</a> - Required additionally if the autoLoginUser parameter is set to true</li></ul>
            var workflowId = workflowId_example;  // string | The workflow identifier, as retrieved from the API to fetch workflows.
            var customWorkflowAgreementCreationRequest = new CustomWorkflowAgreementCreationRequest(); // CustomWorkflowAgreementCreationRequest | Information about the agreement that you want to send and authoring options that you want to apply at the time of sending. NOTE: optional specified with the input parameters is a general guideline on normal request sent to this endpoint. You need to check the actual workflow definition to determine whether a parameter is required or optional.
            var xUserId = xUserId_example;  // string | The ID of the user on whose behalf agreement is being created. (optional) 
            var xUserEmail = xUserEmail_example;  // string | The email address of the user on whose behalf agreement is being created. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. (optional) 

            try
            {
                // Creates an agreement. Sends it out for signatures, and returns the agreementId in the response to the client.
                AgreementCreationResponse result = apiInstance.CreateWorkflowAgreement(accessToken, workflowId, customWorkflowAgreementCreationRequest, xUserId, xUserEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowsApi.CreateWorkflowAgreement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;workflow_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;workflow_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;workflow_read&lt;/a&gt; - To read the workflow resource which will be used for agreement creation&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_send&lt;/a&gt; - If authoringRequested parameter is set to false&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt; - If authoringRequested parameter is set to true&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - Required additionally if the autoLoginUser parameter is set to true&lt;/li&gt;&lt;/ul&gt; | 
 **workflowId** | **string**| The workflow identifier, as retrieved from the API to fetch workflows. | 
 **customWorkflowAgreementCreationRequest** | [**CustomWorkflowAgreementCreationRequest**](CustomWorkflowAgreementCreationRequest.md)| Information about the agreement that you want to send and authoring options that you want to apply at the time of sending. NOTE: optional specified with the input parameters is a general guideline on normal request sent to this endpoint. You need to check the actual workflow definition to determine whether a parameter is required or optional. | 
 **xUserId** | **string**| The ID of the user on whose behalf agreement is being created. | [optional] 
 **xUserEmail** | **string**| The email address of the user on whose behalf agreement is being created. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. | [optional] 

### Return type

[**AgreementCreationResponse**](AgreementCreationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkflowinfo"></a>
# **GetWorkflowInfo**
> WorkflowDescription GetWorkflowInfo (string accessToken, string workflowId)

Retrieves the details of a workflow.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWorkflowInfoExample
    {
        public void main()
        {
            
            var apiInstance = new WorkflowsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('workflow_read')\" oncontextmenu=\"this.href=oauthDoc('workflow_read')\" target=\"oauthDoc\">workflow_read</a></li></ul>
            var workflowId = workflowId_example;  // string | The workflow identifier, as retrieved from the API to fetch workflows.

            try
            {
                // Retrieves the details of a workflow.
                WorkflowDescription result = apiInstance.GetWorkflowInfo(accessToken, workflowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowsApi.GetWorkflowInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;workflow_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;workflow_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;workflow_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **workflowId** | **string**| The workflow identifier, as retrieved from the API to fetch workflows. | 

### Return type

[**WorkflowDescription**](WorkflowDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkflows"></a>
# **GetWorkflows**
> UserWorkflows GetWorkflows (string accessToken, string xUserId, string xUserEmail, bool? includeDraftWorkflows, string groupId)

Retrieves workflows for a user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWorkflowsExample
    {
        public void main()
        {
            
            var apiInstance = new WorkflowsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('workflow_read')\" oncontextmenu=\"this.href=oauthDoc('workflow_read')\" target=\"oauthDoc\">workflow_read</a></li></ul>
            var xUserId = xUserId_example;  // string | The ID of the user whose workflows are being requested. (optional) 
            var xUserEmail = xUserEmail_example;  // string | The email address of the user whose workflows are being requested. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. (optional) 
            var includeDraftWorkflows = true;  // bool? | Include draft workflows (optional) 
            var groupId = groupId_example;  // string | The group identifier for which the workflows will be fetched (optional) 

            try
            {
                // Retrieves workflows for a user.
                UserWorkflows result = apiInstance.GetWorkflows(accessToken, xUserId, xUserEmail, includeDraftWorkflows, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowsApi.GetWorkflows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;workflow_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;workflow_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;workflow_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **xUserId** | **string**| The ID of the user whose workflows are being requested. | [optional] 
 **xUserEmail** | **string**| The email address of the user whose workflows are being requested. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. | [optional] 
 **includeDraftWorkflows** | **bool?**| Include draft workflows | [optional] 
 **groupId** | **string**| The group identifier for which the workflows will be fetched | [optional] 

### Return type

[**UserWorkflows**](UserWorkflows.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

