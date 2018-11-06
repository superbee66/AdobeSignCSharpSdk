# IO.Swagger.Model.LibraryDocumentCreationInfoV6
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedDate** | **DateTime?** | Date when library document was created. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time | [optional] 
**TemplateTypes** | **List&lt;string&gt;** | A list of one or more library template types | [optional] 
**CreatorEmail** | **string** | Email address of the library document creator. It will be ignored in POST call | [optional] 
**SharingMode** | **string** | Specifies who should have access to this library document. GLOBAL sharing mode is not applicable in POST/PUT calls | [optional] 
**Name** | **string** | The name of the library template that will be used to identify it, in emails and on the website | [optional] 
**FileInfos** | [**List&lt;FileInfo&gt;**](FileInfo.md) | A list of one or more files (or references to files) that will be used to create the template. If more than one file is provided, they will be combined into one PDF. Note: Only a single parameter in every FileInfo object must be specified | [optional] 
**Id** | **string** | The unique identifier that is used to refer to the library template. It will be ignored in POST call | [optional] 
**State** | **string** | State of the library document. | [optional] 
**Status** | **string** | Status of the library document | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

