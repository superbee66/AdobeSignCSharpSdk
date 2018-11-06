# IO.Swagger.Model.FileInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransientDocumentId** | **string** | ID for a transient document that will be added to the agreement | [optional] 
**Document** | [**Document**](Document.md) | A document that is associated with the widget. This field cannot be provided in POST call. In case of GET call, this is the only field returned in the response | [optional] 
**LibraryDocumentId** | **string** | ID for an existing Library document that will be added to the agreement | [optional] 
**Label** | **string** | The unique label value of a file info element. In case of custom workflow this will map a file to corresponding file element in workflow definition. This must be specified in case of custom workflow agreement creation request  | [optional] 
**UrlFileInfo** | [**URLFileInfo**](URLFileInfo.md) | URL for an external document to add to the agreement | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

