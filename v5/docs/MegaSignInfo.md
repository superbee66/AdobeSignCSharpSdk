# IO.Swagger.Model.MegaSignInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the document, specified by the sender | [optional] 
**Expiration** | **DateTime?** | The date after which the document can no longer be signed, if an expiration date is configured. The value is nil if an expiration date is not set for the document | [optional] 
**Locale** | **string** | The locale associated with this agreement - for example, en_US or fr_FR | [optional] 
**Message** | **string** | The message associated with the document that the sender has provided | [optional] 
**SecurityOptions** | **List&lt;string&gt;** | Security information about the document that specifies whether or not a password is required to view and sign the document | [optional] 
**Events** | [**List&lt;DocumentHistoryEvent&gt;**](DocumentHistoryEvent.md) | An ordered list of the events in the audit trail of this document | [optional] 
**MegaSignId** | **string** | Unique identifier of the MegaSign parent agreement | [optional] 
**Status** | **string** | Current status of the MegaSign parent agreement from the perspective of the user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

