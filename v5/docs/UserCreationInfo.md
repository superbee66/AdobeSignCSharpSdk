# IO.Swagger.Model.UserCreationInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | The first name of the new user | [optional] 
**LastName** | **string** | The last name of the new user | [optional] 
**Password** | **string** | The password of the new user | [optional] 
**Phone** | **string** | The phone number of the new user | [optional] 
**GroupId** | **string** | Group in which the new user should be added. It can be obtained through a call to the API which retrieves users. Default is Group of the user making this call. The user is inferred from the access_token header. | [optional] 
**Roles** | **List&lt;string&gt;** | The current roles of the user | [optional] 
**OptIn** | **string** | Whether or not the user has opted in to receive marketing information from Adobe Sign and its partners. Default value is UNKNOWN | [optional] 
**Company** | **string** | The name of the company of the new user | [optional] 
**Title** | **string** | The job title of the new user | [optional] 
**Email** | **string** | The email address of the new user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

