# IO.Swagger.Model.AgreementInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignatureType** | **string** | Specifies the type of signature you would like to request - written or e-signature. The possible values are &lt;br&gt; ESIGN : Agreement needs to be signed electronically &lt;br&gt;, WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into the system | [optional] 
**ExternalId** | [**ExternalId**](ExternalId.md) | An arbitrary value from your system, which can be specified at sending time and then later returned or queried | [optional] 
**LatestVersionId** | **string** | An ID which uniquely identifies the current version of the document | [optional] 
**Locale** | **string** | The locale associated with this agreement - for example, en_US or fr_FR | [optional] 
**Message** | **string** | The message associated with the document that the sender has provided | [optional] 
**SecurityOptions** | **List&lt;string&gt;** | Security information about the document that specifies whether or not a password is required to view and sign the document | [optional] 
**NextParticipantSetInfos** | [**List&lt;NextParticipantSetInfo&gt;**](NextParticipantSetInfo.md) | Information about who needs to act next for this document - for example, if the agreement is in status OUT_FOR_SIGNATURE or OUT_FOR_APPROVAL, this will be the next signer or approver. If the AgreementStatus is a terminal state, this array is empty | [optional] 
**ParticipantSetInfos** | [**List&lt;ParticipantSetInfo&gt;**](ParticipantSetInfo.md) | Information about all the participant sets of this document | [optional] 
**AgreementId** | **string** | A resource identifier that can be used to uniquely identify the agreement resource in other apis | [optional] 
**Name** | **string** | The name of the document, specified by the sender | [optional] 
**VaultingEnabled** | **bool?** | Whether vaulting was enabled for the agreement | [optional] 
**Expiration** | **DateTime?** | The date after which the document can no longer be signed, if an expiration date is configured. The value is nil if an expiration date is not set for the document | [optional] 
**Modifiable** | **bool?** | Information about whether the agreement can be modified | [optional] 
**Events** | [**List&lt;DocumentHistoryEvent&gt;**](DocumentHistoryEvent.md) | An ordered list of the events in the audit trail of this document | [optional] 
**Status** | **string** | The current status of the document | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

