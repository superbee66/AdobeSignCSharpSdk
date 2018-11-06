# IO.Swagger.Model.AgreementStatusUpdateInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NotifySigner** | **bool?** | Whether or not you would like the recipient to be notified that the transaction has been cancelled. The notification is mandatory if any party has already signed this document. The default value is false. In case the invoker is a signer, the flag has no effect. | [optional] 
**Comment** | **string** | An optional comment describing to the recipient why you want to cancel the transaction.  Mandatory if the caller is a signer. | [optional] 
**Value** | **string** | The state to which the agreement is to be updated. The only valid state for this variable is currently, CANCEL | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

