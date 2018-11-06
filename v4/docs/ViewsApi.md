# IO.Swagger.Api.ViewsApi

All URIs are relative to *https://secure.na1.echosign.com/api/rest/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAgreementAssetListUrl**](ViewsApi.md#createagreementassetlisturl) | **POST** /views/agreementAssetList | Returns the URL for manage page.
[**CreateAgreementAssetUrl**](ViewsApi.md#createagreementasseturl) | **POST** /views/agreementAssets | Returns the URL which shows the view page of given agreement asset.
[**CreateSettingsUrl**](ViewsApi.md#createsettingsurl) | **POST** /views/settings | Returns the URL for settings page.


<a name="createagreementassetlisturl"></a>
# **CreateAgreementAssetListUrl**
> ViewUrl CreateAgreementAssetListUrl (string accessToken, string xUserId, string xUserEmail, AgreementAssetListRequest agreementAssetListRequest)

Returns the URL for manage page.

This endpoint will return the URL for manage page. If an agreement asset id is given then that agreement asset will be shown selected in the resulted manage page url.The agreement asset refers to any asset through which an agreement can be created for instance library document,widget and agreement itself.                        If the user wants to generate a URL that will automatically log the user in then user_login scope is required in the given Oauth Access Token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAgreementAssetListUrlExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('user_login')\" oncontextmenu=\"this.href=oauthDoc('user_login')\" target=\"oauthDoc\">user_login</a> - If the user wants to generate a URL that will automatically log the user in then this  scope is required else any valid scope can be used</li></ul>
            var xUserId = xUserId_example;  // string | The ID of the user for whom URL is being generated. (optional) 
            var xUserEmail = xUserEmail_example;  // string | The email address of the user for whom URL is being generated. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. (optional) 
            var agreementAssetListRequest = new AgreementAssetListRequest(); // AgreementAssetListRequest | Information about the type of url to be generated for Manage Page (optional) 

            try
            {
                // Returns the URL for manage page.
                ViewUrl result = apiInstance.CreateAgreementAssetListUrl(accessToken, xUserId, xUserEmail, agreementAssetListRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CreateAgreementAssetListUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - If the user wants to generate a URL that will automatically log the user in then this  scope is required else any valid scope can be used&lt;/li&gt;&lt;/ul&gt; | 
 **xUserId** | **string**| The ID of the user for whom URL is being generated. | [optional] 
 **xUserEmail** | **string**| The email address of the user for whom URL is being generated. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. | [optional] 
 **agreementAssetListRequest** | [**AgreementAssetListRequest**](AgreementAssetListRequest.md)| Information about the type of url to be generated for Manage Page | [optional] 

### Return type

[**ViewUrl**](ViewUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createagreementasseturl"></a>
# **CreateAgreementAssetUrl**
> ViewUrl CreateAgreementAssetUrl (string accessToken, AgreementAssetRequest agreementAssetRequest, string xUserId, string xUserEmail)

Returns the URL which shows the view page of given agreement asset.

This endpoint will return the URL of view agreement page for an agreement asset. The agreement asset refers to any asset through which an agreement can be created for instance library document,widget and agreement itself.                     If the user wants to generate a URL that will automatically log the user in then user_login scope is required in the given Oauth Access Token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAgreementAssetUrlExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('agreement_read')\" oncontextmenu=\"this.href=oauthDoc('agreement_read')\" target=\"oauthDoc\">agreement_read</a> - Required when agreementAssetId refers to an agreement</li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('widget_read')\" oncontextmenu=\"this.href=oauthDoc('widget_read')\" target=\"oauthDoc\">widget_read</a> - Required when agreementAssetId refers to a widget</li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('library_read')\" oncontextmenu=\"this.href=oauthDoc('library_read')\" target=\"oauthDoc\">library_read</a> - Required when agreementAssetId refers to a library document</li><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('user_login')\" oncontextmenu=\"this.href=oauthDoc('user_login')\" target=\"oauthDoc\">user_login</a> - In addition to one of the above scopes, this scope is required if the user wants to generate a URL that will automatically log the user in.</li></ul>
            var agreementAssetRequest = new AgreementAssetRequest(); // AgreementAssetRequest | Information about the type of url to be generated for Agreement Asset Page
            var xUserId = xUserId_example;  // string | The ID of the user for whom URL is being generated. (optional) 
            var xUserEmail = xUserEmail_example;  // string | The email address of the user for whom URL is being generated. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. (optional) 

            try
            {
                // Returns the URL which shows the view page of given agreement asset.
                ViewUrl result = apiInstance.CreateAgreementAssetUrl(accessToken, agreementAssetRequest, xUserId, xUserEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CreateAgreementAssetUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_read&lt;/a&gt; - Required when agreementAssetId refers to an agreement&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_read&lt;/a&gt; - Required when agreementAssetId refers to a widget&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_read&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_read&lt;/a&gt; - Required when agreementAssetId refers to a library document&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - In addition to one of the above scopes, this scope is required if the user wants to generate a URL that will automatically log the user in.&lt;/li&gt;&lt;/ul&gt; | 
 **agreementAssetRequest** | [**AgreementAssetRequest**](AgreementAssetRequest.md)| Information about the type of url to be generated for Agreement Asset Page | 
 **xUserId** | **string**| The ID of the user for whom URL is being generated. | [optional] 
 **xUserEmail** | **string**| The email address of the user for whom URL is being generated. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. | [optional] 

### Return type

[**ViewUrl**](ViewUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsettingsurl"></a>
# **CreateSettingsUrl**
> ViewUrl CreateSettingsUrl (string accessToken, TargetViewRequest targetViewRequest, string xUserId, string xUserEmail)

Returns the URL for settings page.

This endpoint will return the URL for Settings Page. The settings page can be of two types - user profile page(for non admin) and account settings page(for admin). If the user wants to generate a URL that will automatically log the user in then user_login scope is required in the given Oauth Access Token.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSettingsUrlExample
    {
        public void main()
        {
            
            var apiInstance = new ViewsApi();
            var accessToken = accessToken_example;  // string | An <a href=\"#\" onclick=\"this.href=oauthDoc()\" oncontextmenu=\"this.href=oauthDoc()\" target=\"oauthDoc\">OAuth Access Token</a> with scopes:<ul><li style='list-style-type: square'><a href=\"#\" onclick=\"this.href=oauthDoc('user_login')\" oncontextmenu=\"this.href=oauthDoc('user_login')\" target=\"oauthDoc\">user_login</a> - If the user wants to generate a URL that will automatically log the user in then this  scope is required else any valid scope can be used</li></ul>
            var targetViewRequest = new TargetViewRequest(); // TargetViewRequest | Information about the type of url to be generated for various Settings page
            var xUserId = xUserId_example;  // string | The ID of the user for whom URL is being generated. (optional) 
            var xUserEmail = xUserEmail_example;  // string | The email address of the user for whom URL is being generated. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. (optional) 

            try
            {
                // Returns the URL for settings page.
                ViewUrl result = apiInstance.CreateSettingsUrl(accessToken, targetViewRequest, xUserId, xUserEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.CreateSettingsUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;user_login&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;user_login&lt;/a&gt; - If the user wants to generate a URL that will automatically log the user in then this  scope is required else any valid scope can be used&lt;/li&gt;&lt;/ul&gt; | 
 **targetViewRequest** | [**TargetViewRequest**](TargetViewRequest.md)| Information about the type of url to be generated for various Settings page | 
 **xUserId** | **string**| The ID of the user for whom URL is being generated. | [optional] 
 **xUserEmail** | **string**| The email address of the user for whom URL is being generated. If both X-User-Id and X-User-Email are provided then X-User-Id is given preference. If neither is specified then the user is inferred from the access token. | [optional] 

### Return type

[**ViewUrl**](ViewUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

