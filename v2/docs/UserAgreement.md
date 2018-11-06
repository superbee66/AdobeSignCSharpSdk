# IO.Swagger.Model.UserAgreement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayDate** | **DateTime?** | The display date for the agreement | [optional] 
**DisplayUserInfo** | [**DisplayUserInfo**](DisplayUserInfo.md) | The most relevant current user for the agreement. It is typically the next signer if the agreement is from the current user, or the sender if received from another user | [optional] 
**Esign** | **bool?** | True if this is an e-sign document | [optional] 
**AgreementId** | **string** | The unique identifier of the agreement | [optional] 
**Name** | **string** | Name of the Agreement | [optional] 
**LatestVersionId** | **string** | A version ID which uniquely identifies the current version of the agreement | [optional] 
**Status** | **string** | The current status of the document from the perspective of the user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

