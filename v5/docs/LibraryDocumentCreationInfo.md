# IO.Swagger.Model.LibraryDocumentCreationInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LibrarySharingMode** | **string** | Specifies who should have access to this library document | [optional] 
**LibraryTemplateTypes** | **List&lt;string&gt;** | A list of one or more library template types | [optional] 
**Name** | **string** | The name of the library template that will be used to identify it, in emails and on the website | [optional] 
**FileInfos** | [**List&lt;FileInfo&gt;**](FileInfo.md) | A list of one or more files (or references to files) that will be used to create the template. If more than one file is provided, they will be combined into one PDF. Note: Only a single parameter in every FileInfo object must be specified | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

