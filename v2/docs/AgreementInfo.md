# IO.Swagger.Model.AgreementInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextParticipantInfos** | [**List&lt;NextParticipantInfo&gt;**](NextParticipantInfo.md) | Information about who needs to act next for this document - for example, if the agreement is in status OUT_FOR_SIGNATURE or OUT_FOR_APPROVAL, this will be the next signer or approver. If the AgreementStatus is a terminal state, this array is empty | [optional] 
**AgreementId** | **string** | A resource identifier that can be used to uniquely identify the agreement resource in other apis | [optional] 
**Name** | **string** | The name of the document, specified by the sender | [optional] 
**Expiration** | **DateTime?** | The date after which the document can no longer be signed, if an expiration date is configured. The value is nil if an expiration date is not set for the document | [optional] 
**LatestVersionId** | **string** | An ID which uniquely identifies the current version of the document | [optional] 
**Locale** | **string** | The locale associated with this agreement - for example, en_US or fr_FR | [optional] 
**Message** | **string** | The message associated with the document that the sender has provided | [optional] 
**SecurityOptions** | **List&lt;string&gt;** | Security information about the document that specifies whether or not a password is required to view and sign the document | [optional] 
**Events** | [**List&lt;DocumentHistoryEvent&gt;**](DocumentHistoryEvent.md) | An ordered list of the events in the audit trail of this document | [optional] 
**Participants** | [**List&lt;ParticipantInfo&gt;**](ParticipantInfo.md) | Information about all the participants of this document | [optional] 
**Status** | **string** | The current status of the document | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

