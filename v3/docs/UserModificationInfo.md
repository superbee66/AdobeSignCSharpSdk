# IO.Swagger.Model.UserModificationInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | The new first name of the user | [optional] 
**LastName** | **string** | The new last name of the user | [optional] 
**Phone** | **string** | The new phone number of the user. The server will reset to null if the value is not provided | [optional] 
**GroupId** | **string** | The new group in which the user should be added. It can be obtained through &lt;b&gt;GET /users&lt;/b&gt; call. The server will reset to default if the value is not provided  | [optional] 
**Roles** | **List&lt;string&gt;** | The new roles of the user | [optional] 
**OptIn** | **string** | Whether or not the user has opted in to receive the marketing information from Adobe Sign and its partners. The server will reset to null if the value is not provided.  | [optional] 
**Company** | **string** | The new company name of the user. The server will reset to null if the value is not provided | [optional] 
**Title** | **string** | The new job title of the user. The server will reset to null if the value is not provided | [optional] 
**Email** | **string** | The new email address of the user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

