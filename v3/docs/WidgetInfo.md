# IO.Swagger.Model.WidgetInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WidgetId** | **string** | A resource identifier that can be used to uniquely identify the widget in other apis | [optional] 
**Name** | **string** | The widget name specified by the sender | [optional] 
**LatestVersionId** | **string** | An ID which uniquely identifies the current version of the widget | [optional] 
**Locale** | **string** | The locale associated with this widget - for example, en_US or fr_FR | [optional] 
**Message** | **string** | The message associated with the widget that the sender has provided | [optional] 
**SecurityOptions** | **List&lt;string&gt;** | Security information about the widget that specifies whether or not a password is required to view and sign the widget | [optional] 
**Events** | [**List&lt;WidgetHistoryEvent&gt;**](WidgetHistoryEvent.md) | An ordered list of the events in the audit trail of this widget | [optional] 
**Javascript** | **string** | The embedded javascript code of the widget | [optional] 
**Url** | **string** | The hosted url of the widget | [optional] 
**Participants** | [**List&lt;WidgetParticipantInfo&gt;**](WidgetParticipantInfo.md) | Information about all the participants of this widget | [optional] 
**Status** | **string** | The current status of the widget | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

