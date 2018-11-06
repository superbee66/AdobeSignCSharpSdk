# IO.Swagger.Api.LibraryDocumentsApi

All URIs are relative to *https://secure.na1.echosign.com/api/rest/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCombinedDocument**](LibraryDocumentsApi.md#getcombineddocument) | **GET** /libraryDocuments/{libraryDocumentId}/combinedDocument | Retrieves the combined document associated with a library document.
[**GetDocuments**](LibraryDocumentsApi.md#getdocuments) | **GET** /libraryDocuments/{libraryDocumentId}/documents | Retrieves the IDs of the documents associated with library document.
[**GetLibraryDocument**](LibraryDocumentsApi.md#getlibrarydocument) | **GET** /libraryDocuments/{libraryDocumentId}/documents/{documentId} | Retrieves the file stream of a document of library document.
[**GetLibraryDocumentAuditTrail**](LibraryDocumentsApi.md#getlibrarydocumentaudittrail) | **GET** /libraryDocuments/{libraryDocumentId}/auditTrail | Retrieves the audit trail associated with a library document.
[**GetLibraryDocumentInfo**](LibraryDocumentsApi.md#getlibrarydocumentinfo) | **GET** /libraryDocuments/{libraryDocumentId} | Retrieves the details of a library document.
[**GetLibraryDocuments**](LibraryDocumentsApi.md#getlibrarydocuments) | **GET** /libraryDocuments | Retrieves library documents for a user.


<a name="getcombineddocument"></a>
# **GetCombinedDocument**
> byte[] GetCombinedDocument (string accessToken, string libraryDocumentId, bool? auditReport)

Retrieves the combined document associated with a library document.

File Stream of PDF file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCombinedDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new LibraryDocumentsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('library_read')\" oncontextmenu=\"this.href=oauthDoc('library_read')\" target=\"oauthDoc\">library_read</a></li></ul>(Legacy clients can use the access token obtained from /auth/tokens endpoint.)
            var libraryDocumentId = libraryDocumentId_example;  // string | The document identifier, as retrieved from the API to fetch library documents.
            var auditReport = true;  // bool? | When set to YES attach an audit report to the library document PDF. Default value will be false. (optional) 

            try
            {
                // Retrieves the combined document associated with a library document.
                byte[] result = apiInstance.GetCombinedDocument(accessToken, libraryDocumentId, auditReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibraryDocumentsApi.GetCombinedDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.) | 
 **libraryDocumentId** | **string**| The document identifier, as retrieved from the API to fetch library documents. | 
 **auditReport** | **bool?**| When set to YES attach an audit report to the library document PDF. Default value will be false. | [optional] 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocuments"></a>
# **GetDocuments**
> Documents GetDocuments (string accessToken, string libraryDocumentId)

Retrieves the IDs of the documents associated with library document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new LibraryDocumentsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('library_read')\" oncontextmenu=\"this.href=oauthDoc('library_read')\" target=\"oauthDoc\">library_read</a></li></ul>(Legacy clients can use the access token obtained from /auth/tokens endpoint.)
            var libraryDocumentId = libraryDocumentId_example;  // string | The document identifier, as retrieved from the API to fetch library documents.

            try
            {
                // Retrieves the IDs of the documents associated with library document.
                Documents result = apiInstance.GetDocuments(accessToken, libraryDocumentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibraryDocumentsApi.GetDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.) | 
 **libraryDocumentId** | **string**| The document identifier, as retrieved from the API to fetch library documents. | 

### Return type

[**Documents**](Documents.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlibrarydocument"></a>
# **GetLibraryDocument**
> byte[] GetLibraryDocument (string accessToken, string libraryDocumentId, string documentId)

Retrieves the file stream of a document of library document.

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
    public class GetLibraryDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new LibraryDocumentsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('library_read')\" oncontextmenu=\"this.href=oauthDoc('library_read')\" target=\"oauthDoc\">library_read</a></li></ul>(Legacy clients can use the access token obtained from /auth/tokens endpoint.)
            var libraryDocumentId = libraryDocumentId_example;  // string | The document identifier, as retrieved from the API to fetch library documents.
            var documentId = documentId_example;  // string | The document identifier, as retrieved from the API which fetches the documents of a specified library document

            try
            {
                // Retrieves the file stream of a document of library document.
                byte[] result = apiInstance.GetLibraryDocument(accessToken, libraryDocumentId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibraryDocumentsApi.GetLibraryDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.) | 
 **libraryDocumentId** | **string**| The document identifier, as retrieved from the API to fetch library documents. | 
 **documentId** | **string**| The document identifier, as retrieved from the API which fetches the documents of a specified library document | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**:    *_/_*   

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlibrarydocumentaudittrail"></a>
# **GetLibraryDocumentAuditTrail**
> byte[] GetLibraryDocumentAuditTrail (string accessToken, string libraryDocumentId)

Retrieves the audit trail associated with a library document.

File Stream of PDF file

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLibraryDocumentAuditTrailExample
    {
        public void main()
        {
            
            var apiInstance = new LibraryDocumentsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('library_read')\" oncontextmenu=\"this.href=oauthDoc('library_read')\" target=\"oauthDoc\">library_read</a></li></ul>(Legacy clients can use the access token obtained from /auth/tokens endpoint.)
            var libraryDocumentId = libraryDocumentId_example;  // string | The document identifier, as retrieved from the API to fetch library documents.

            try
            {
                // Retrieves the audit trail associated with a library document.
                byte[] result = apiInstance.GetLibraryDocumentAuditTrail(accessToken, libraryDocumentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibraryDocumentsApi.GetLibraryDocumentAuditTrail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.) | 
 **libraryDocumentId** | **string**| The document identifier, as retrieved from the API to fetch library documents. | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlibrarydocumentinfo"></a>
# **GetLibraryDocumentInfo**
> LibraryDocumentInfo GetLibraryDocumentInfo (string accessToken, string libraryDocumentId)

Retrieves the details of a library document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLibraryDocumentInfoExample
    {
        public void main()
        {
            
            var apiInstance = new LibraryDocumentsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('library_read')\" oncontextmenu=\"this.href=oauthDoc('library_read')\" target=\"oauthDoc\">library_read</a></li></ul>(Legacy clients can use the access token obtained from /auth/tokens endpoint.)
            var libraryDocumentId = libraryDocumentId_example;  // string | The document identifier, as retrieved from the API to fetch library documents.

            try
            {
                // Retrieves the details of a library document.
                LibraryDocumentInfo result = apiInstance.GetLibraryDocumentInfo(accessToken, libraryDocumentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibraryDocumentsApi.GetLibraryDocumentInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.) | 
 **libraryDocumentId** | **string**| The document identifier, as retrieved from the API to fetch library documents. | 

### Return type

[**LibraryDocumentInfo**](LibraryDocumentInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlibrarydocuments"></a>
# **GetLibraryDocuments**
> DocumentLibraryItems GetLibraryDocuments (string accessToken, string xUserId, string xUserEmail, string libraryTemplateType)

Retrieves library documents for a user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLibraryDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new LibraryDocumentsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('library_read')\" oncontextmenu=\"this.href=oauthDoc('library_read')\" target=\"oauthDoc\">library_read</a></li></ul>(Legacy clients can use the access token obtained from /auth/tokens endpoint.)
            var xUserId = xUserId_example;  // string | The ID of the user whose library documents are being requested. (optional) 
            var xUserEmail = xUserEmail_example;  // string | The email address of the user whose library documents are being requested. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. (optional) 
            var libraryTemplateType = libraryTemplateType_example;  // string | The type of library template. It can have two possible values DOCUMENT or FORM_FIELD_LAYER. If not specified all the library templates will be retrieved. (optional) 

            try
            {
                // Retrieves library documents for a user.
                DocumentLibraryItems result = apiInstance.GetLibraryDocuments(accessToken, xUserId, xUserEmail, libraryTemplateType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LibraryDocumentsApi.GetLibraryDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;(Legacy clients can use the access token obtained from /auth/tokens endpoint.) | 
 **xUserId** | **string**| The ID of the user whose library documents are being requested. | [optional] 
 **xUserEmail** | **string**| The email address of the user whose library documents are being requested. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. | [optional] 
 **libraryTemplateType** | **string**| The type of library template. It can have two possible values DOCUMENT or FORM_FIELD_LAYER. If not specified all the library templates will be retrieved. | [optional] 

### Return type

[**DocumentLibraryItems**](DocumentLibraryItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

