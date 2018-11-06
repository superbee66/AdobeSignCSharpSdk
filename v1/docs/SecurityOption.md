# IO.Swagger.Model.SecurityOption
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KbaProtection** | **string** | Signers need to pass Knowledge Based Authentication before they gain access to view and sign the document. | [optional] 
**Password** | **string** | The secondary password that is used to secure the document. Note that Adobe Sign never displays this password. You need to communicate this password to the appropriate users. Note: This field is required if either sign or open password option was set | [optional] 
**PasswordProtection** | **string** | Specifies if signers are required to enter a password to have access to sign the document. | [optional] 
**WebIdentityProtection** | **string** | Specifies if signers are required to provide their web identity, before they gain access to view and sign the document. | [optional] 
**ProtectOpen** | **bool?** | If set to true, the document is always be encrypted with this password every time it is sent by email. Recipients need to provide the password to be able to view the PDF files | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

