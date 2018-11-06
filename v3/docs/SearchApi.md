# IO.Swagger.Api.SearchApi

All URIs are relative to *https://secure.na1.echosign.com/api/rest/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAssetEvent**](SearchApi.md#createassetevent) | **POST** /search/agreementAssetEvents | Create a search object for agreement asset event . It will return the result for the first page and search Id to fetch results for further pages.
[**GetAssetEvent**](SearchApi.md#getassetevent) | **GET** /search/agreementAssetEvents/{searchId} | Return the result for the page which is described inside the Page Cursor Info.


<a name="createassetevent"></a>
# **CreateAssetEvent**
> AgreementAssetEventPostResponse CreateAssetEvent (string accessToken, AgreementAssetEventRequest agreementAssetEventRequest, string xUserId, string xUserEmail)

Create a search object for agreement asset event . It will return the result for the first page and search Id to fetch results for further pages.

The agreement asset refers to any asset through which an agreement can be created for instance library document,widget and agreement itself. To search for Agreement Asset Events, first make a request to the API that creates agreementAssetEvents with relevant search parameters. Response will be the first page of results along with a search Id param and next page cursor. These can be used to fetch further page results if they are  available using the API which retrieves agreementAssetEvents based on searchId

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAssetEventExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_read')\" oncontextmenu=\"this.href=oauthDoc('widget_read')\" target=\"oauthDoc\">widget_read</a></li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('library_read')\" oncontextmenu=\"this.href=oauthDoc('library_read')\" target=\"oauthDoc\">library_read</a></li></ul>
            var agreementAssetEventRequest = new AgreementAssetEventRequest(); // AgreementAssetEventRequest | Information about the Agreement Asset Events to be generated
            var xUserId = xUserId_example;  // string | The ID of the user for whom agreement asset events are fetched. (optional) 
            var xUserEmail = xUserEmail_example;  // string | The email address of the user for whom agreement asset events are fetched. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. (optional) 

            try
            {
                // Create a search object for agreement asset event . It will return the result for the first page and search Id to fetch results for further pages.
                AgreementAssetEventPostResponse result = apiInstance.CreateAssetEvent(accessToken, agreementAssetEventRequest, xUserId, xUserEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.CreateAssetEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementAssetEventRequest** | [**AgreementAssetEventRequest**](AgreementAssetEventRequest.md)| Information about the Agreement Asset Events to be generated | 
 **xUserId** | **string**| The ID of the user for whom agreement asset events are fetched. | [optional] 
 **xUserEmail** | **string**| The email address of the user for whom agreement asset events are fetched. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. | [optional] 

### Return type

[**AgreementAssetEventPostResponse**](AgreementAssetEventPostResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassetevent"></a>
# **GetAssetEvent**
> AgreementAssetEventGetResponse GetAssetEvent (string accessToken, string searchId, string pageCursor, string xUserId, string xUserEmail, int? pageSize)

Return the result for the page which is described inside the Page Cursor Info.

The agreement asset refers to any asset through which an agreement can be created for instance library document,widget and agreement itself. Provide the searchId obtained from the API that creates agreementAssetEvents and the next page cursor id from the original call to the API that creates agreementAssetEvents or a previous call to the API that retrieves agreementAssetEvents based on searchId.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssetEventExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_read')\" oncontextmenu=\"this.href=oauthDoc('widget_read')\" target=\"oauthDoc\">widget_read</a></li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('library_read')\" oncontextmenu=\"this.href=oauthDoc('library_read')\" target=\"oauthDoc\">library_read</a></li></ul>
            var searchId = searchId_example;  // string | The search object identifier, as returned by the agreementAssetEvent creation API .
            var pageCursor = pageCursor_example;  // string | Page cursor of the page whose result will be fetched
            var xUserId = xUserId_example;  // string | The ID of the user for whom agreement asset events are fetched. (optional) 
            var xUserEmail = xUserEmail_example;  // string | The email address of the user for whom agreement asset events are fetched. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. (optional) 
            var pageSize = 56;  // int? | Count of agreement asset events which will be returned in the response. If the pageSize is left blank, then the pageSize which is mentioned while making POST request to /search/agreementAssetEvents will be used. Maximum page size is 500. (optional) 

            try
            {
                // Return the result for the page which is described inside the Page Cursor Info.
                AgreementAssetEventGetResponse result = apiInstance.GetAssetEvent(accessToken, searchId, pageCursor, xUserId, xUserEmail, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetAssetEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **searchId** | **string**| The search object identifier, as returned by the agreementAssetEvent creation API . | 
 **pageCursor** | **string**| Page cursor of the page whose result will be fetched | 
 **xUserId** | **string**| The ID of the user for whom agreement asset events are fetched. | [optional] 
 **xUserEmail** | **string**| The email address of the user for whom agreement asset events are fetched. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. | [optional] 
 **pageSize** | **int?**| Count of agreement asset events which will be returned in the response. If the pageSize is left blank, then the pageSize which is mentioned while making POST request to /search/agreementAssetEvents will be used. Maximum page size is 500. | [optional] 

### Return type

[**AgreementAssetEventGetResponse**](AgreementAssetEventGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

