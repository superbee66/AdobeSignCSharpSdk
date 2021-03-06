# IO.Swagger - the C# library for the 

No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 4.0.0
- SDK version: 1.0.0
- Build date: 2018-11-06T11:05:56.824-07:00
- Build package: io.swagger.codegen.languages.CsharpDotNet2ClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are bundled with this generator

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://secure.na1.echosign.com/api/rest/v4*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*WorkflowsApi* | [**CreateWorkflowAgreement**](docs/WorkflowsApi.md#createworkflowagreement) | **POST** /workflows/{workflowId}/agreements | Creates an agreement. Sends it out for signatures, and returns the agreementId in the response to the client.
*WorkflowsApi* | [**GetWorkflowInfo**](docs/WorkflowsApi.md#getworkflowinfo) | **GET** /workflows/{workflowId} | Retrieves the details of a workflow.
*WorkflowsApi* | [**GetWorkflows**](docs/WorkflowsApi.md#getworkflows) | **GET** /workflows | Retrieves workflows for a user.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [IO.Swagger.Model.AgreementCreationResponse](docs/AgreementCreationResponse.md)
 - [IO.Swagger.Model.CCsListInfoDescription](docs/CCsListInfoDescription.md)
 - [IO.Swagger.Model.CcsInfo](docs/CcsInfo.md)
 - [IO.Swagger.Model.CustomWorkflowAgreementCreationRequest](docs/CustomWorkflowAgreementCreationRequest.md)
 - [IO.Swagger.Model.CustomWorkflowFileInfo](docs/CustomWorkflowFileInfo.md)
 - [IO.Swagger.Model.DocumentCreationInfo](docs/DocumentCreationInfo.md)
 - [IO.Swagger.Model.ExpirationFieldInfoDescription](docs/ExpirationFieldInfoDescription.md)
 - [IO.Swagger.Model.FileInfo](docs/FileInfo.md)
 - [IO.Swagger.Model.FileInfosDescription](docs/FileInfosDescription.md)
 - [IO.Swagger.Model.FormFieldCondition](docs/FormFieldCondition.md)
 - [IO.Swagger.Model.FormFieldLocation](docs/FormFieldLocation.md)
 - [IO.Swagger.Model.InteractiveOptions](docs/InteractiveOptions.md)
 - [IO.Swagger.Model.LocaleFieldInfoDescription](docs/LocaleFieldInfoDescription.md)
 - [IO.Swagger.Model.MergeFieldInfoDescription](docs/MergeFieldInfoDescription.md)
 - [IO.Swagger.Model.MergefieldInfo](docs/MergefieldInfo.md)
 - [IO.Swagger.Model.PasswordFieldInfoDescription](docs/PasswordFieldInfoDescription.md)
 - [IO.Swagger.Model.PostSignOptions](docs/PostSignOptions.md)
 - [IO.Swagger.Model.RecipientInfo](docs/RecipientInfo.md)
 - [IO.Swagger.Model.RecipientsInfo](docs/RecipientsInfo.md)
 - [IO.Swagger.Model.RecipientsListInfoDescription](docs/RecipientsListInfoDescription.md)
 - [IO.Swagger.Model.SecurityOption](docs/SecurityOption.md)
 - [IO.Swagger.Model.URLFileInfo](docs/URLFileInfo.md)
 - [IO.Swagger.Model.UserWorkflow](docs/UserWorkflow.md)
 - [IO.Swagger.Model.UserWorkflows](docs/UserWorkflows.md)
 - [IO.Swagger.Model.VaultingInfo](docs/VaultingInfo.md)
 - [IO.Swagger.Model.WorkflowBasedFormField](docs/WorkflowBasedFormField.md)
 - [IO.Swagger.Model.WorkflowDefaultParams](docs/WorkflowDefaultParams.md)
 - [IO.Swagger.Model.WorkflowDescription](docs/WorkflowDescription.md)
 - [IO.Swagger.Model.WorkflowLibraryDocument](docs/WorkflowLibraryDocument.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
