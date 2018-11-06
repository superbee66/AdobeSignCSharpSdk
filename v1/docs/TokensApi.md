# IO.Swagger.Api.TokensApi

All URIs are relative to *https://secure.na1.echosign.com/api/rest/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAccessToken**](TokensApi.md#createaccesstoken) | **POST** /auth/tokens | Issues an access token for a user of an application.


<a name="createaccesstoken"></a>
# **CreateAccessToken**
> AccessToken CreateAccessToken (RESTCredentials rESTCredentials)

Issues an access token for a user of an application.

Application credentials can be obtained from the Adobe Sign Application page. User credentials can be a combination of email and password, or the API key of the user. The access token returned by this endpoint has a validity of 14 days and is a required header parameter for all the other endpoints that requires an authenticated user.  NOTE: This endpoint is deprecated and will be removed in a future release - please use an <a href=\"javascript:void(0)\" onclick=\"window.open(oauthDoc(),'oauthDoc').focus()\">OAuth Access Token</a> instead.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAccessTokenExample
    {
        public void main()
        {
            
            var apiInstance = new TokensApi();
            var rESTCredentials = new RESTCredentials(); // RESTCredentials | The user and application credentials to use for issuing the access token.

            try
            {
                // Issues an access token for a user of an application.
                AccessToken result = apiInstance.CreateAccessToken(rESTCredentials);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokensApi.CreateAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rESTCredentials** | [**RESTCredentials**](RESTCredentials.md)| The user and application credentials to use for issuing the access token. | 

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

