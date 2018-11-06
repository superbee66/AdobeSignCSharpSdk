# IO.Swagger.Model.AgreementEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | The date of the audit event. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time | [optional] 
**InitiatingUserName** | **string** | Full name of the user that initiated the event on behalf of the acting user when the account is shared. Will be empty if there is no account sharing in effect | [optional] 
**Description** | **string** | A description of the audit event | [optional] 
**ActingUserName** | **string** | The name of the acting user | [optional] 
**ActingUserIpAddress** | **string** | The IP address of the user that created the event | [optional] 
**ParticipantEmail** | **string** | Email address of the user that is the participant for the event. This may be different than the acting user for certain event types. For example, for a DELEGATION event, this is the user who was delegated to | [optional] 
**Type** | **string** | Type of agreement event | [optional] 
**ParticipantRole** | **string** | Role assumed by all participants in the participant set the participant belongs to (signer, approver etc.). | [optional] 
**VaultEventId** | **string** | The identifier assigned by the vault provider for the vault event (if vaulted, otherwise null) | [optional] 
**ParticipantId** | **string** | The unique identifier of the participant for the event. This may be different than the acting user for certain event types. For example, for a DELEGATION event, this is the user who was delegated to | [optional] 
**VersionId** | **string** | An ID which uniquely identifies the version of the document associated with this audit event | [optional] 
**ActingUserEmail** | **string** | Email address of the user that created the event | [optional] 
**DevicePhoneNumber** | **string** | Phone number from the device used when the participation is completed on a mobile phone | [optional] 
**InitiatingUserEmail** | **string** | Email address of the user that initiated the event on behalf of the acting user when the account is shared. Will be empty if there is no account sharing in effect | [optional] 
**DigitalSignatureInfo** | [**DigitalSignatureInfo**](DigitalSignatureInfo.md) | This is present for ESIGNED events when the participation is signed digitally | [optional] 
**VaultProviderName** | **string** | Name of the vault provider for the vault event (if vaulted, otherwise null) | [optional] 
**Comment** | **string** | The event comment. For RECALLED or REJECTED, the reason given by the user that initiates the event. For DELEGATE or SHARE, the message from the acting user to the participant | [optional] 
**SynchronizationId** | **string** | A unique identifier linking offline events to synchronization events (specified for offline signing events and synchronization events, else null) | [optional] 
**DeviceLocation** | [**DeviceLocation**](DeviceLocation.md) | Location of the device that generated the event (This value may be null due to limited privileges) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

