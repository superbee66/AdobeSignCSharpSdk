# IO.Swagger.Model.WidgetStatusUpdateInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RedirectUrl** | **string** | Redirect the user to this URL when the widget is accessed. This is required if message is not provided. Both message and redirectUrl can not be specified. | [optional] 
**Message** | **string** | Display this custom message to the user when the widget is accessed. Note that this can contain wiki markup to include clickable links in the message. This is required if redirectUrl is not provided. Both message and redirectUrl can not be specified. | [optional] 
**Value** | **string** | The status to which the widget is to be updated. The possible values for this variable are ENABLE and DISABLE | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

