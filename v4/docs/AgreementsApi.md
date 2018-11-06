# IO.Swagger.Api.AgreementsApi

All URIs are relative to *https://secure.na1.echosign.com/api/rest/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAgreement**](AgreementsApi.md#createagreement) | **POST** /agreements | Creates an agreement. Sends it out for signatures, and returns the agreementID in the response to the client.
[**DeleteAgreement**](AgreementsApi.md#deleteagreement) | **DELETE** /agreements/{agreementId} | Deletes an agreement. Agreement will no longer be visible in the Manage Page of the user.
[**GetAgreementInfo**](AgreementsApi.md#getagreementinfo) | **GET** /agreements/{agreementId} | Retrieves the current status of an agreement.
[**GetAgreements**](AgreementsApi.md#getagreements) | **GET** /agreements | Retrieves agreements for the user.
[**GetAllDocuments**](AgreementsApi.md#getalldocuments) | **GET** /agreements/{agreementId}/documents | Retrieves the IDs of the documents of an agreement identified by agreementId.
[**GetAllDocumentsImageUrls**](AgreementsApi.md#getalldocumentsimageurls) | **GET** /agreements/{agreementId}/documents/imageUrls | Retrieves image urls of all visible pages of all the documents associated with an agreement.
[**GetAuditTrail**](AgreementsApi.md#getaudittrail) | **GET** /agreements/{agreementId}/auditTrail | Retrieves the audit trail of an agreement identified by agreementId.
[**GetCombinedDocument**](AgreementsApi.md#getcombineddocument) | **GET** /agreements/{agreementId}/combinedDocument | Gets a single combined PDF document for the documents associated with an agreement.
[**GetCombinedDocumentPagesInfo**](AgreementsApi.md#getcombineddocumentpagesinfo) | **GET** /agreements/{agreementId}/combinedDocument/pagesInfo | Retrieves info of all pages of a combined PDF document for the documents associated with an agreement.
[**GetCombinedDocumentUrl**](AgreementsApi.md#getcombineddocumenturl) | **GET** /agreements/{agreementId}/combinedDocument/url | Retrieves url of all visible pages of all the documents associated with an agreement.
[**GetDocument**](AgreementsApi.md#getdocument) | **GET** /agreements/{agreementId}/documents/{documentId} | Retrieves the file stream of a document of an agreement.
[**GetDocumentImageUrls**](AgreementsApi.md#getdocumentimageurls) | **GET** /agreements/{agreementId}/documents/{documentId}/imageUrls | Retrieves image urls of all visible pages of a document associated with an agreement.
[**GetDocumentUrl**](AgreementsApi.md#getdocumenturl) | **GET** /agreements/{agreementId}/documents/{documentId}/url | Retrieves the url of the document
[**GetFormData**](AgreementsApi.md#getformdata) | **GET** /agreements/{agreementId}/formData | Retrieves data entered by the user into interactive form fields at the time they signed the agreement.
[**GetSigningUrl**](AgreementsApi.md#getsigningurl) | **GET** /agreements/{agreementId}/signingUrls | Retrieves the URL for the e-sign page for the current signer(s) of an agreement.
[**UpdateStatus**](AgreementsApi.md#updatestatus) | **PUT** /agreements/{agreementId}/status | Cancels an agreement.


<a name="createagreement"></a>
# **CreateAgreement**
> AgreementCreationResponse CreateAgreement (string accessToken, AgreementCreationInfo agreementCreationInfo, string xUserId, string xUserEmail)

Creates an agreement. Sends it out for signatures, and returns the agreementID in the response to the client.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAgreementExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_send')\" oncontextmenu=\"this.href=oauthDoc('agreement_send')\" target=\"oauthDoc\">agreement_send</a> - If both authoringRequested and sendThroughWeb parameter are set to false</li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_write')\" oncontextmenu=\"this.href=oauthDoc('agreement_write')\" target=\"oauthDoc\">agreement_write</a> - If any of the authoringRequested or sendThroughWeb parameter is set to true</li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('user_login')\" oncontextmenu=\"this.href=oauthDoc('user_login')\" target=\"oauthDoc\">user_login</a> - Required additionally if the autoLoginUser parameter is set to true</li></ul>
            var agreementCreationInfo = new AgreementCreationInfo(); // AgreementCreationInfo | Information about the agreement that you want to send and authoring options that you want to apply at the time of sending.
            var xUserId = xUserId_example;  // string | The ID of the user on whose behalf agreement is being created. (optional) 
            var xUserEmail = xUserEmail_example;  // string | The email address of the user on whose behalf agreement is being created. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. (optional) 

            try
            {
                // Creates an agreement. Sends it out for signatures, and returns the agreementID in the response to the client.
                AgreementCreationResponse result = apiInstance.CreateAgreement(accessToken, agreementCreationInfo, xUserId, xUserEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.CreateAgreement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_send&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_send&lt;/a&gt; - If both authoringRequested and sendThroughWeb parameter are set to false&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt; - If any of the authoringRequested or sendThroughWeb parameter is set to true&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - Required additionally if the autoLoginUser parameter is set to true&lt;/li&gt;&lt;/ul&gt; | 
 **agreementCreationInfo** | [**AgreementCreationInfo**](AgreementCreationInfo.md)| Information about the agreement that you want to send and authoring options that you want to apply at the time of sending. | 
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

<a name="deleteagreement"></a>
# **DeleteAgreement**
> void DeleteAgreement (string accessToken, string agreementId)

Deletes an agreement. Agreement will no longer be visible in the Manage Page of the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAgreementExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_retention')\" oncontextmenu=\"this.href=oauthDoc('agreement_retention')\" target=\"oauthDoc\">agreement_retention</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.

            try
            {
                // Deletes an agreement. Agreement will no longer be visible in the Manage Page of the user.
                apiInstance.DeleteAgreement(accessToken, agreementId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.DeleteAgreement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_retention&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_retention&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_retention&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagreementinfo"></a>
# **GetAgreementInfo**
> AgreementInfo GetAgreementInfo (string accessToken, string agreementId)

Retrieves the current status of an agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAgreementInfoExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.

            try
            {
                // Retrieves the current status of an agreement.
                AgreementInfo result = apiInstance.GetAgreementInfo(accessToken, agreementId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetAgreementInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 

### Return type

[**AgreementInfo**](AgreementInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagreements"></a>
# **GetAgreements**
> UserAgreements GetAgreements (string accessToken, string xUserId, string xUserEmail, string query, string externalId, string externalGroup, string externalNamespace)

Retrieves agreements for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAgreementsExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var xUserId = xUserId_example;  // string | The ID of the user whose agreements are being requested. (optional) 
            var xUserEmail = xUserEmail_example;  // string | The email address of the user whose agreements are being requested. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. (optional) 
            var query = query_example;  // string | The query string used for the search. Multiple search terms can be provided, separated by spaces. Some of the search terms include document name, participant name or company, and form data (optional) 
            var externalId = externalId_example;  // string | Case-sensitive ExternalID for which you would like to retrieve agreement information. ExternalId is passed in the call to the agreement creation API. (optional) 
            var externalGroup = externalGroup_example;  // string | ExternalGroup for which you would like to retrieve agreement information. ExternalGroup is passed in the call to the agreement creation API. You must pass ExternalId if passing ExternalGroup parameter (optional) 
            var externalNamespace = externalNamespace_example;  // string | ExternalNameSpace for which you would like to retrieve agreement information. ExternalNameSpace is passed in the call to the agreement creation API. You must pass ExternalId if passing ExternalNameSpace parameter (optional) 

            try
            {
                // Retrieves agreements for the user.
                UserAgreements result = apiInstance.GetAgreements(accessToken, xUserId, xUserEmail, query, externalId, externalGroup, externalNamespace);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetAgreements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **xUserId** | **string**| The ID of the user whose agreements are being requested. | [optional] 
 **xUserEmail** | **string**| The email address of the user whose agreements are being requested. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. | [optional] 
 **query** | **string**| The query string used for the search. Multiple search terms can be provided, separated by spaces. Some of the search terms include document name, participant name or company, and form data | [optional] 
 **externalId** | **string**| Case-sensitive ExternalID for which you would like to retrieve agreement information. ExternalId is passed in the call to the agreement creation API. | [optional] 
 **externalGroup** | **string**| ExternalGroup for which you would like to retrieve agreement information. ExternalGroup is passed in the call to the agreement creation API. You must pass ExternalId if passing ExternalGroup parameter | [optional] 
 **externalNamespace** | **string**| ExternalNameSpace for which you would like to retrieve agreement information. ExternalNameSpace is passed in the call to the agreement creation API. You must pass ExternalId if passing ExternalNameSpace parameter | [optional] 

### Return type

[**UserAgreements**](UserAgreements.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalldocuments"></a>
# **GetAllDocuments**
> AgreementDocuments GetAllDocuments (string accessToken, string agreementId, string versionId, string participantEmail, string supportingDocumentContentFormat)

Retrieves the IDs of the documents of an agreement identified by agreementId.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.
            var versionId = versionId_example;  // string | The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. (optional) 
            var participantEmail = participantEmail_example;  // string | The email address of the participant to be used to retrieve documents. (optional) 
            var supportingDocumentContentFormat = supportingDocumentContentFormat_example;  // string | Content format of the supported documents. It can have two possible values ORIGINAL or CONVERTED_PDF. Default value is CONVERTED_PDF. (optional) 

            try
            {
                // Retrieves the IDs of the documents of an agreement identified by agreementId.
                AgreementDocuments result = apiInstance.GetAllDocuments(accessToken, agreementId, versionId, participantEmail, supportingDocumentContentFormat);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetAllDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 
 **versionId** | **string**| The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. | [optional] 
 **participantEmail** | **string**| The email address of the participant to be used to retrieve documents. | [optional] 
 **supportingDocumentContentFormat** | **string**| Content format of the supported documents. It can have two possible values ORIGINAL or CONVERTED_PDF. Default value is CONVERTED_PDF. | [optional] 

### Return type

[**AgreementDocuments**](AgreementDocuments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalldocumentsimageurls"></a>
# **GetAllDocumentsImageUrls**
> DocumentImageUrls GetAllDocumentsImageUrls (string accessToken, string agreementId, string versionId, string participantEmail, string imageSizes, bool? includeSupportingDocumentsImageUrls, bool? showImageAvailabilityOnly)

Retrieves image urls of all visible pages of all the documents associated with an agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllDocumentsImageUrlsExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.
            var versionId = versionId_example;  // string | The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. (optional) 
            var participantEmail = participantEmail_example;  // string | The email address of the participant to be used to retrieve its visible document pages' image urls. (optional) 
            var imageSizes = imageSizes_example;  // string | A comma separated list of image sizes i.e. {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_50_PERCENT, ZOOM_75_PERCENT, ZOOM_100_PERCENT, ZOOM_125_PERCENT, ZOOM_150_PERCENT, ZOOM_200_PERCENT}. Default sizes returned are {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_100_PERCENT}.  (optional) 
            var includeSupportingDocumentsImageUrls = true;  // bool? | When set to true, returns image urls of supporting documents as well. Else, returns image urls of only the original documents. (optional) 
            var showImageAvailabilityOnly = true;  // bool? | When set to true, returns only image availability. Else, returns both image urls and its availability. (optional) 

            try
            {
                // Retrieves image urls of all visible pages of all the documents associated with an agreement.
                DocumentImageUrls result = apiInstance.GetAllDocumentsImageUrls(accessToken, agreementId, versionId, participantEmail, imageSizes, includeSupportingDocumentsImageUrls, showImageAvailabilityOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetAllDocumentsImageUrls: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 
 **versionId** | **string**| The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. | [optional] 
 **participantEmail** | **string**| The email address of the participant to be used to retrieve its visible document pages&#39; image urls. | [optional] 
 **imageSizes** | **string**| A comma separated list of image sizes i.e. {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_50_PERCENT, ZOOM_75_PERCENT, ZOOM_100_PERCENT, ZOOM_125_PERCENT, ZOOM_150_PERCENT, ZOOM_200_PERCENT}. Default sizes returned are {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_100_PERCENT}.  | [optional] 
 **includeSupportingDocumentsImageUrls** | **bool?**| When set to true, returns image urls of supporting documents as well. Else, returns image urls of only the original documents. | [optional] 
 **showImageAvailabilityOnly** | **bool?**| When set to true, returns only image availability. Else, returns both image urls and its availability. | [optional] 

### Return type

[**DocumentImageUrls**](DocumentImageUrls.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaudittrail"></a>
# **GetAuditTrail**
> byte[] GetAuditTrail (string accessToken, string agreementId)

Retrieves the audit trail of an agreement identified by agreementId.

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
    public class GetAuditTrailExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.

            try
            {
                // Retrieves the audit trail of an agreement identified by agreementId.
                byte[] result = apiInstance.GetAuditTrail(accessToken, agreementId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetAuditTrail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**:    *_/_*   

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcombineddocument"></a>
# **GetCombinedDocument**
> byte[] GetCombinedDocument (string accessToken, string agreementId, string versionId, string participantEmail, bool? attachSupportingDocuments, bool? auditReport)

Gets a single combined PDF document for the documents associated with an agreement.

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
    public class GetCombinedDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.
            var versionId = versionId_example;  // string | The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. (optional) 
            var participantEmail = participantEmail_example;  // string | The email address of the participant to be used to retrieve documents. (optional) 
            var attachSupportingDocuments = true;  // bool? | When set to true, attach corresponding supporting documents to the signed agreement PDF. Default value of this parameter is true. (optional) 
            var auditReport = true;  // bool? | When set to true, attach an audit report to the signed agreement PDF. Default value is false (optional) 

            try
            {
                // Gets a single combined PDF document for the documents associated with an agreement.
                byte[] result = apiInstance.GetCombinedDocument(accessToken, agreementId, versionId, participantEmail, attachSupportingDocuments, auditReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetCombinedDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 
 **versionId** | **string**| The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. | [optional] 
 **participantEmail** | **string**| The email address of the participant to be used to retrieve documents. | [optional] 
 **attachSupportingDocuments** | **bool?**| When set to true, attach corresponding supporting documents to the signed agreement PDF. Default value of this parameter is true. | [optional] 
 **auditReport** | **bool?**| When set to true, attach an audit report to the signed agreement PDF. Default value is false | [optional] 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**:    *_/_*   

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcombineddocumentpagesinfo"></a>
# **GetCombinedDocumentPagesInfo**
> CombinedDocumentPagesInfo GetCombinedDocumentPagesInfo (string accessToken, string agreementId, bool? includeSupportingDocumentsPagesInfo)

Retrieves info of all pages of a combined PDF document for the documents associated with an agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCombinedDocumentPagesInfoExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.
            var includeSupportingDocumentsPagesInfo = true;  // bool? | When set to true, returns info of all pages of supporting documents as well. Else, return the info of pages of only the original document. (optional) 

            try
            {
                // Retrieves info of all pages of a combined PDF document for the documents associated with an agreement.
                CombinedDocumentPagesInfo result = apiInstance.GetCombinedDocumentPagesInfo(accessToken, agreementId, includeSupportingDocumentsPagesInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetCombinedDocumentPagesInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 
 **includeSupportingDocumentsPagesInfo** | **bool?**| When set to true, returns info of all pages of supporting documents as well. Else, return the info of pages of only the original document. | [optional] 

### Return type

[**CombinedDocumentPagesInfo**](CombinedDocumentPagesInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcombineddocumenturl"></a>
# **GetCombinedDocumentUrl**
> DocumentUrl GetCombinedDocumentUrl (string accessToken, string agreementId, string versionId, string participantEmail, bool? attachSupportingDocuments, bool? auditReport)

Retrieves url of all visible pages of all the documents associated with an agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCombinedDocumentUrlExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.
            var versionId = versionId_example;  // string | The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. (optional) 
            var participantEmail = participantEmail_example;  // string | The email address of the participant to be used to retrieve its document url. (optional) 
            var attachSupportingDocuments = true;  // bool? | When set to true, attach corresponding supporting documents to the signed agreement PDF. Default value of this parameter is true. (optional) 
            var auditReport = true;  // bool? | When set to true, attach an audit report to the signed agreement PDF. Default value is false (optional) 

            try
            {
                // Retrieves url of all visible pages of all the documents associated with an agreement.
                DocumentUrl result = apiInstance.GetCombinedDocumentUrl(accessToken, agreementId, versionId, participantEmail, attachSupportingDocuments, auditReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetCombinedDocumentUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 
 **versionId** | **string**| The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. | [optional] 
 **participantEmail** | **string**| The email address of the participant to be used to retrieve its document url. | [optional] 
 **attachSupportingDocuments** | **bool?**| When set to true, attach corresponding supporting documents to the signed agreement PDF. Default value of this parameter is true. | [optional] 
 **auditReport** | **bool?**| When set to true, attach an audit report to the signed agreement PDF. Default value is false | [optional] 

### Return type

[**DocumentUrl**](DocumentUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> byte[] GetDocument (string accessToken, string agreementId, string documentId)

Retrieves the file stream of a document of an agreement.

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
    public class GetDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.
            var documentId = documentId_example;  // string | The document identifier, as retrieved from the API which fetches the documents of a specified agreement

            try
            {
                // Retrieves the file stream of a document of an agreement.
                byte[] result = apiInstance.GetDocument(accessToken, agreementId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 
 **documentId** | **string**| The document identifier, as retrieved from the API which fetches the documents of a specified agreement | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**:    *_/_*   

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentimageurls"></a>
# **GetDocumentImageUrls**
> DocumentImageUrl GetDocumentImageUrls (string accessToken, string agreementId, string documentId, string versionId, string participantEmail, string imageSizes, bool? showImageAvailabilityOnly, int? startPage, int? endPage)

Retrieves image urls of all visible pages of a document associated with an agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDocumentImageUrlsExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.
            var documentId = documentId_example;  // string | The document identifier, as retrieved from the API which fetches the documents of a specified agreement
            var versionId = versionId_example;  // string | The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. (optional) 
            var participantEmail = participantEmail_example;  // string | The email address of the participant to be used to retrieve its visible document pages' image urls. (optional) 
            var imageSizes = imageSizes_example;  // string | A comma separated list of image sizes i.e. {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_50_PERCENT, ZOOM_75_PERCENT, ZOOM_100_PERCENT, ZOOM_125_PERCENT, ZOOM_150_PERCENT, ZOOM_200_PERCENT}. Default sizes returned are {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_100_PERCENT}.  (optional) 
            var showImageAvailabilityOnly = true;  // bool? | When set to true, returns only image availability. Else, returns both image urls and its availability. (optional) 
            var startPage = 56;  // int? | Start of page number range for which imageUrls are requested. Starting page number should be greater than 0. (optional) 
            var endPage = 56;  // int? | End of page number range for which imageUrls are requested. (optional) 

            try
            {
                // Retrieves image urls of all visible pages of a document associated with an agreement.
                DocumentImageUrl result = apiInstance.GetDocumentImageUrls(accessToken, agreementId, documentId, versionId, participantEmail, imageSizes, showImageAvailabilityOnly, startPage, endPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetDocumentImageUrls: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 
 **documentId** | **string**| The document identifier, as retrieved from the API which fetches the documents of a specified agreement | 
 **versionId** | **string**| The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. | [optional] 
 **participantEmail** | **string**| The email address of the participant to be used to retrieve its visible document pages&#39; image urls. | [optional] 
 **imageSizes** | **string**| A comma separated list of image sizes i.e. {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_50_PERCENT, ZOOM_75_PERCENT, ZOOM_100_PERCENT, ZOOM_125_PERCENT, ZOOM_150_PERCENT, ZOOM_200_PERCENT}. Default sizes returned are {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_100_PERCENT}.  | [optional] 
 **showImageAvailabilityOnly** | **bool?**| When set to true, returns only image availability. Else, returns both image urls and its availability. | [optional] 
 **startPage** | **int?**| Start of page number range for which imageUrls are requested. Starting page number should be greater than 0. | [optional] 
 **endPage** | **int?**| End of page number range for which imageUrls are requested. | [optional] 

### Return type

[**DocumentImageUrl**](DocumentImageUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumenturl"></a>
# **GetDocumentUrl**
> DocumentUrl GetDocumentUrl (string accessToken, string agreementId, string documentId, string versionId, string participantEmail)

Retrieves the url of the document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDocumentUrlExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.
            var documentId = documentId_example;  // string | The document identifier, as retrieved from the API which fetches the documents of a specified agreement
            var versionId = versionId_example;  // string | The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. (optional) 
            var participantEmail = participantEmail_example;  // string | The email address of the participant to be used to retrieve its document url. (optional) 

            try
            {
                // Retrieves the url of the document
                DocumentUrl result = apiInstance.GetDocumentUrl(accessToken, agreementId, documentId, versionId, participantEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetDocumentUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 
 **documentId** | **string**| The document identifier, as retrieved from the API which fetches the documents of a specified agreement | 
 **versionId** | **string**| The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used. | [optional] 
 **participantEmail** | **string**| The email address of the participant to be used to retrieve its document url. | [optional] 

### Return type

[**DocumentUrl**](DocumentUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getformdata"></a>
# **GetFormData**
> byte[] GetFormData (string accessToken, string agreementId)

Retrieves data entered by the user into interactive form fields at the time they signed the agreement.

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
    public class GetFormDataExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.

            try
            {
                // Retrieves data entered by the user into interactive form fields at the time they signed the agreement.
                byte[] result = apiInstance.GetFormData(accessToken, agreementId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetFormData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsigningurl"></a>
# **GetSigningUrl**
> SigningUrlResponse GetSigningUrl (string accessToken, string agreementId)

Retrieves the URL for the e-sign page for the current signer(s) of an agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSigningUrlExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_write')\" oncontextmenu=\"this.href=oauthDoc('agreement_write')\" target=\"oauthDoc\">agreement_write</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.

            try
            {
                // Retrieves the URL for the e-sign page for the current signer(s) of an agreement.
                SigningUrlResponse result = apiInstance.GetSigningUrl(accessToken, agreementId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.GetSigningUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 

### Return type

[**SigningUrlResponse**](SigningUrlResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestatus"></a>
# **UpdateStatus**
> AgreementStatusUpdateResponse UpdateStatus (string accessToken, string agreementId, AgreementStatusUpdateInfo agreementStatusUpdateInfo)

Cancels an agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateStatusExample
    {
        public void main()
        {
            
            var apiInstance = new AgreementsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_write')\" oncontextmenu=\"this.href=oauthDoc('agreement_write')\" target=\"oauthDoc\">agreement_write</a></li></ul>
            var agreementId = agreementId_example;  // string | The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.
            var agreementStatusUpdateInfo = new AgreementStatusUpdateInfo(); // AgreementStatusUpdateInfo | Agreement status update information object.

            try
            {
                // Cancels an agreement.
                AgreementStatusUpdateResponse result = apiInstance.UpdateStatus(accessToken, agreementId, agreementStatusUpdateInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.UpdateStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt; | 
 **agreementId** | **string**| The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements. | 
 **agreementStatusUpdateInfo** | [**AgreementStatusUpdateInfo**](AgreementStatusUpdateInfo.md)| Agreement status update information object. | 

### Return type

[**AgreementStatusUpdateResponse**](AgreementStatusUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

