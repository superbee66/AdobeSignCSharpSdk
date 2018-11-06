# IO.Swagger.Api.WidgetsApi

All URIs are relative to *https://secure.na1.echosign.com/api/rest/v5*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWidget**](WidgetsApi.md#createwidget) | **POST** /widgets | Creates a widget and returns the Javascript snippet and URL to access the widget and widgetID in response to the client.
[**GetWidgetAgreements**](WidgetsApi.md#getwidgetagreements) | **GET** /widgets/{widgetId}/agreements | Retrieves agreements for the widget.
[**GetWidgetAuditTrail**](WidgetsApi.md#getwidgetaudittrail) | **GET** /widgets/{widgetId}/auditTrail | Retrieves the audit trail of a widget identified by widgetId.
[**GetWidgetCombinedDocument**](WidgetsApi.md#getwidgetcombineddocument) | **GET** /widgets/{widgetId}/combinedDocument | Gets a single combined PDF document for the documents associated with a widget.
[**GetWidgetDocumentInfo**](WidgetsApi.md#getwidgetdocumentinfo) | **GET** /widgets/{widgetId}/documents/{documentId} | Retrieves the file stream of a document of a widget.
[**GetWidgetDocuments**](WidgetsApi.md#getwidgetdocuments) | **GET** /widgets/{widgetId}/documents | Retrieves the IDs of the documents associated with widget.
[**GetWidgetFormData**](WidgetsApi.md#getwidgetformdata) | **GET** /widgets/{widgetId}/formData | Retrieves data entered by the user into interactive form fields at the time they signed the widget
[**GetWidgetInfo**](WidgetsApi.md#getwidgetinfo) | **GET** /widgets/{widgetId} | Retrieves the details of a widget.
[**GetWidgets**](WidgetsApi.md#getwidgets) | **GET** /widgets | Retrieves widgets for a user.
[**UpdateWidgetPersonalize**](WidgetsApi.md#updatewidgetpersonalize) | **PUT** /widgets/{widgetId}/personalize | Personalize the widget to a signable document for a specific known user
[**UpdateWidgetStatus**](WidgetsApi.md#updatewidgetstatus) | **PUT** /widgets/{widgetId}/status | Enables or Disables a widget.


<a name="createwidget"></a>
# **CreateWidget**
> WidgetCreationResponse CreateWidget (string accessToken, WidgetCreationRequest widgetCreationRequest, string xApiUser)

Creates a widget and returns the Javascript snippet and URL to access the widget and widgetID in response to the client.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateWidgetExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_write')\" oncontextmenu=\"this.href=oauthDoc('widget_write')\" target=\"oauthDoc\">widget_write</a></li></ul>
            var widgetCreationRequest = new WidgetCreationRequest(); // WidgetCreationRequest | Information about the widget that you want to create.
            var xApiUser = xApiUser_example;  // string | The userId or email of API caller using the account or group token in the format <b>userid:{userId} OR email:{email}.</b> If it is not specified, then the caller is inferred from the token. (optional) 

            try
            {
                // Creates a widget and returns the Javascript snippet and URL to access the widget and widgetID in response to the client.
                WidgetCreationResponse result = apiInstance.CreateWidget(accessToken, widgetCreationRequest, xApiUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.CreateWidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **widgetCreationRequest** | [**WidgetCreationRequest**](WidgetCreationRequest.md)| Information about the widget that you want to create. | 
 **xApiUser** | **string**| The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token. | [optional] 

### Return type

[**WidgetCreationResponse**](WidgetCreationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwidgetagreements"></a>
# **GetWidgetAgreements**
> WidgetAgreements GetWidgetAgreements (string accessToken, string widgetId, string xApiUser)

Retrieves agreements for the widget.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWidgetAgreementsExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_read')\" oncontextmenu=\"this.href=oauthDoc('widget_read')\" target=\"oauthDoc\">widget_read</a></li></ul>
            var widgetId = widgetId_example;  // string | The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.
            var xApiUser = xApiUser_example;  // string | The userId or email of API caller using the account or group token in the format <b>userid:{userId} OR email:{email}.</b> If it is not specified, then the caller is inferred from the token. (optional) 

            try
            {
                // Retrieves agreements for the widget.
                WidgetAgreements result = apiInstance.GetWidgetAgreements(accessToken, widgetId, xApiUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.GetWidgetAgreements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **widgetId** | **string**| The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets. | 
 **xApiUser** | **string**| The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token. | [optional] 

### Return type

[**WidgetAgreements**](WidgetAgreements.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwidgetaudittrail"></a>
# **GetWidgetAuditTrail**
> byte[] GetWidgetAuditTrail (string accessToken, string widgetId, string xApiUser)

Retrieves the audit trail of a widget identified by widgetId.

PDF file stream containing audit trail information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWidgetAuditTrailExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_read')\" oncontextmenu=\"this.href=oauthDoc('widget_read')\" target=\"oauthDoc\">widget_read</a></li></ul>
            var widgetId = widgetId_example;  // string | The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.
            var xApiUser = xApiUser_example;  // string | The userId or email of API caller using the account or group token in the format <b>userid:{userId} OR email:{email}.</b> If it is not specified, then the caller is inferred from the token. (optional) 

            try
            {
                // Retrieves the audit trail of a widget identified by widgetId.
                byte[] result = apiInstance.GetWidgetAuditTrail(accessToken, widgetId, xApiUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.GetWidgetAuditTrail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **widgetId** | **string**| The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets. | 
 **xApiUser** | **string**| The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token. | [optional] 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwidgetcombineddocument"></a>
# **GetWidgetCombinedDocument**
> byte[] GetWidgetCombinedDocument (string accessToken, string widgetId, string xApiUser, string versionId, string participantEmail, bool? auditReport)

Gets a single combined PDF document for the documents associated with a widget.

A File Stream of combined PDF document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWidgetCombinedDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_read')\" oncontextmenu=\"this.href=oauthDoc('widget_read')\" target=\"oauthDoc\">widget_read</a></li></ul>
            var widgetId = widgetId_example;  // string | The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.
            var xApiUser = xApiUser_example;  // string | The userId or email of API caller using the account or group token in the format <b>userid:{userId} OR email:{email}.</b> If it is not specified, then the caller is inferred from the token. (optional) 
            var versionId = versionId_example;  // string | The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used. (optional) 
            var participantEmail = participantEmail_example;  // string | The email address of the participant to be used to retrieve documents. (optional) 
            var auditReport = true;  // bool? | When set to YES, attach an audit report to the signed Widget PDF. Default value is false (optional) 

            try
            {
                // Gets a single combined PDF document for the documents associated with a widget.
                byte[] result = apiInstance.GetWidgetCombinedDocument(accessToken, widgetId, xApiUser, versionId, participantEmail, auditReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.GetWidgetCombinedDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **widgetId** | **string**| The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets. | 
 **xApiUser** | **string**| The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token. | [optional] 
 **versionId** | **string**| The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used. | [optional] 
 **participantEmail** | **string**| The email address of the participant to be used to retrieve documents. | [optional] 
 **auditReport** | **bool?**| When set to YES, attach an audit report to the signed Widget PDF. Default value is false | [optional] 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwidgetdocumentinfo"></a>
# **GetWidgetDocumentInfo**
> byte[] GetWidgetDocumentInfo (string accessToken, string widgetId, string documentId, string xApiUser)

Retrieves the file stream of a document of a widget.

Raw stream of the file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWidgetDocumentInfoExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_read')\" oncontextmenu=\"this.href=oauthDoc('widget_read')\" target=\"oauthDoc\">widget_read</a></li></ul>
            var widgetId = widgetId_example;  // string | The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.
            var documentId = documentId_example;  // string | The document identifier, as retrieved from the API which fetches the documents of a specified widget
            var xApiUser = xApiUser_example;  // string | The userId or email of API caller using the account or group token in the format <b>userid:{userId} OR email:{email}.</b> If it is not specified, then the caller is inferred from the token. (optional) 

            try
            {
                // Retrieves the file stream of a document of a widget.
                byte[] result = apiInstance.GetWidgetDocumentInfo(accessToken, widgetId, documentId, xApiUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.GetWidgetDocumentInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **widgetId** | **string**| The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets. | 
 **documentId** | **string**| The document identifier, as retrieved from the API which fetches the documents of a specified widget | 
 **xApiUser** | **string**| The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token. | [optional] 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**:    *_/_*   

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwidgetdocuments"></a>
# **GetWidgetDocuments**
> WidgetDocuments GetWidgetDocuments (string accessToken, string widgetId, string xApiUser, string versionId, string participantEmail)

Retrieves the IDs of the documents associated with widget.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWidgetDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_read')\" oncontextmenu=\"this.href=oauthDoc('widget_read')\" target=\"oauthDoc\">widget_read</a></li></ul>
            var widgetId = widgetId_example;  // string | The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.
            var xApiUser = xApiUser_example;  // string | The userId or email of API caller using the account or group token in the format <b>userid:{userId} OR email:{email}.</b> If it is not specified, then the caller is inferred from the token. (optional) 
            var versionId = versionId_example;  // string | The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used. (optional) 
            var participantEmail = participantEmail_example;  // string | The email address of the participant to be used to retrieve documents. (optional) 

            try
            {
                // Retrieves the IDs of the documents associated with widget.
                WidgetDocuments result = apiInstance.GetWidgetDocuments(accessToken, widgetId, xApiUser, versionId, participantEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.GetWidgetDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **widgetId** | **string**| The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets. | 
 **xApiUser** | **string**| The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token. | [optional] 
 **versionId** | **string**| The version identifier of widget as provided by the API which retrieves information of a specific widget. If not provided then latest version will be used. | [optional] 
 **participantEmail** | **string**| The email address of the participant to be used to retrieve documents. | [optional] 

### Return type

[**WidgetDocuments**](WidgetDocuments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwidgetformdata"></a>
# **GetWidgetFormData**
> byte[] GetWidgetFormData (string accessToken, string widgetId, string xApiUser)

Retrieves data entered by the user into interactive form fields at the time they signed the widget

CSV file stream containing form data information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWidgetFormDataExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_read')\" oncontextmenu=\"this.href=oauthDoc('widget_read')\" target=\"oauthDoc\">widget_read</a></li></ul>
            var widgetId = widgetId_example;  // string | The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.
            var xApiUser = xApiUser_example;  // string | The userId or email of API caller using the account or group token in the format <b>userid:{userId} OR email:{email}.</b> If it is not specified, then the caller is inferred from the token. (optional) 

            try
            {
                // Retrieves data entered by the user into interactive form fields at the time they signed the widget
                byte[] result = apiInstance.GetWidgetFormData(accessToken, widgetId, xApiUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.GetWidgetFormData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **widgetId** | **string**| The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets. | 
 **xApiUser** | **string**| The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token. | [optional] 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwidgetinfo"></a>
# **GetWidgetInfo**
> WidgetInfo GetWidgetInfo (string accessToken, string widgetId, string xApiUser)

Retrieves the details of a widget.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWidgetInfoExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_read')\" oncontextmenu=\"this.href=oauthDoc('widget_read')\" target=\"oauthDoc\">widget_read</a></li></ul>
            var widgetId = widgetId_example;  // string | The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.
            var xApiUser = xApiUser_example;  // string | The userId or email of API caller using the account or group token in the format <b>userid:{userId} OR email:{email}.</b> If it is not specified, then the caller is inferred from the token. (optional) 

            try
            {
                // Retrieves the details of a widget.
                WidgetInfo result = apiInstance.GetWidgetInfo(accessToken, widgetId, xApiUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.GetWidgetInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **widgetId** | **string**| The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets. | 
 **xApiUser** | **string**| The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token. | [optional] 

### Return type

[**WidgetInfo**](WidgetInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwidgets"></a>
# **GetWidgets**
> UserWidgets GetWidgets (string accessToken, string xApiUser)

Retrieves widgets for a user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWidgetsExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_read')\" oncontextmenu=\"this.href=oauthDoc('widget_read')\" target=\"oauthDoc\">widget_read</a></li></ul>
            var xApiUser = xApiUser_example;  // string | The userId or email of API caller using the account or group token in the format <b>userid:{userId} OR email:{email}.</b> If it is not specified, then the caller is inferred from the token. (optional) 

            try
            {
                // Retrieves widgets for a user.
                UserWidgets result = apiInstance.GetWidgets(accessToken, xApiUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.GetWidgets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **xApiUser** | **string**| The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token. | [optional] 

### Return type

[**UserWidgets**](UserWidgets.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewidgetpersonalize"></a>
# **UpdateWidgetPersonalize**
> WidgetPersonalizeResponse UpdateWidgetPersonalize (string accessToken, string widgetId, WidgetPersonalizationInfo widgetPersonalizationInfo, string xApiUser)

Personalize the widget to a signable document for a specific known user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateWidgetPersonalizeExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_write')\" oncontextmenu=\"this.href=oauthDoc('widget_write')\" target=\"oauthDoc\">widget_write</a></li></ul>
            var widgetId = widgetId_example;  // string | The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.
            var widgetPersonalizationInfo = new WidgetPersonalizationInfo(); // WidgetPersonalizationInfo | Widget Personalize update information object
            var xApiUser = xApiUser_example;  // string | The userId or email of API caller using the account or group token in the format <b>userid:{userId} OR email:{email}.</b> If it is not specified, then the caller is inferred from the token. (optional) 

            try
            {
                // Personalize the widget to a signable document for a specific known user
                WidgetPersonalizeResponse result = apiInstance.UpdateWidgetPersonalize(accessToken, widgetId, widgetPersonalizationInfo, xApiUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.UpdateWidgetPersonalize: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **widgetId** | **string**| The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets. | 
 **widgetPersonalizationInfo** | [**WidgetPersonalizationInfo**](WidgetPersonalizationInfo.md)| Widget Personalize update information object | 
 **xApiUser** | **string**| The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token. | [optional] 

### Return type

[**WidgetPersonalizeResponse**](WidgetPersonalizeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewidgetstatus"></a>
# **UpdateWidgetStatus**
> WidgetStatusUpdateResponse UpdateWidgetStatus (string accessToken, string widgetId, WidgetStatusUpdateInfo widgetStatusUpdateInfo, string xApiUser)

Enables or Disables a widget.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateWidgetStatusExample
    {
        public void main()
        {
            
            var apiInstance = new WidgetsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_write')\" oncontextmenu=\"this.href=oauthDoc('widget_write')\" target=\"oauthDoc\">widget_write</a></li></ul>
            var widgetId = widgetId_example;  // string | The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets.
            var widgetStatusUpdateInfo = new WidgetStatusUpdateInfo(); // WidgetStatusUpdateInfo | Widget status update information object.
            var xApiUser = xApiUser_example;  // string | The userId or email of API caller using the account or group token in the format <b>userid:{userId} OR email:{email}.</b> If it is not specified, then the caller is inferred from the token. (optional) 

            try
            {
                // Enables or Disables a widget.
                WidgetStatusUpdateResponse result = apiInstance.UpdateWidgetStatus(accessToken, widgetId, widgetStatusUpdateInfo, xApiUser);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetsApi.UpdateWidgetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **widgetId** | **string**| The widget identifier, as returned by the widget creation API or retrieved from the API to fetch widgets. | 
 **widgetStatusUpdateInfo** | [**WidgetStatusUpdateInfo**](WidgetStatusUpdateInfo.md)| Widget status update information object. | 
 **xApiUser** | **string**| The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token. | [optional] 

### Return type

[**WidgetStatusUpdateResponse**](WidgetStatusUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

