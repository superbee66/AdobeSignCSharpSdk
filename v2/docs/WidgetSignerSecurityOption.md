# IO.Swagger.Model.WidgetSignerSecurityOption
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **string** | The password required for the recipient to view and sign the widget | [optional] 
**AuthenticationMethod** | **string** | The authentication method for the recipients to have access to view and sign the widget. PHONE authentication is only applicable to counter signers but not to widget signer | [optional] 
**PhoneInfos** | [**List&lt;PhoneInfo&gt;**](PhoneInfo.md) | The phoneInfo required for the counter signer to view and sign the widget if authentication method is PHONE. Not applicable to widget signer | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

