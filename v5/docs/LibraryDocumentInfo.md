# IO.Swagger.Model.LibraryDocumentInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the document, specified by the sender | [optional] 
**LibraryDocumentId** | **string** | A resource identifier that can be used to uniquely identify the library document in other apis | [optional] 
**LatestVersionId** | **string** | An ID which uniquely identifies the current version of the library document | [optional] 
**Locale** | **string** | The locale associated with this agreement - for example, en_US or fr_FR | [optional] 
**Message** | **string** | The message associated with the document that the sender has provided | [optional] 
**SecurityOptions** | **List&lt;string&gt;** | Security information about the document that specifies whether or not a password is required to view and sign the document | [optional] 
**Events** | [**List&lt;LibDocumentHistoryEvent&gt;**](LibDocumentHistoryEvent.md) | An ordered list of the events in the audit trail of this document | [optional] 
**Participants** | [**List&lt;LibDocParticipantInfo&gt;**](LibDocParticipantInfo.md) | Information about all the participants of this document | [optional] 
**Status** | **string** | The current status of the document | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

