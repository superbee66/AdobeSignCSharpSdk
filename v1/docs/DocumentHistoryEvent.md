# IO.Swagger.Model.DocumentHistoryEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | The date of the audit event | [optional] 
**VersionId** | **string** | An ID which uniquely identifies the version of the document associated with this audit event | [optional] 
**ActingUserEmail** | **string** | Email address of the user that initiated the event | [optional] 
**Description** | **string** | A description of the audit event | [optional] 
**Comment** | **string** | The event comment. For RECALLED or REJECTED, the reason given by the user that initiates the event. For DELEGATE or SHARE, the message from the acting user to the participant | [optional] 
**ActingUserIpAddress** | **string** | The IP address of the user that initiated the event | [optional] 
**ParticipantEmail** | **string** | Email address of the user that initiated the event | [optional] 
**SynchronizationId** | **string** | A unique identifier linking offline events to synchronization events (specified for offline signing events and synchronization events, else null) | [optional] 
**VaultEventId** | **string** | The identifier assigned by the vault provider for the vault event (if vaulted, otherwise null) | [optional] 
**DeviceLocation** | [**DeviceLocation**](DeviceLocation.md) | Location of the device that created the event (This value may be null due to limited privileges) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

