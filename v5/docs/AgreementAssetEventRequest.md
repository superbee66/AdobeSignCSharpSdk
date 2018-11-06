# IO.Swagger.Model.AgreementAssetEventRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndDate** | **DateTime?** | The end of the date range for which events will be returned. Date should be mentioned in YYYY-MM-DDTHH:MM:SS format | [optional] 
**PageSize** | **int?** | Count of agreement asset events which will be returned in the response. Default page size for the response is 100. Maximum value of page size is 500 | [optional] 
**OnlyShowLatestEvent** | **bool?** | If true, only the latest event for any given agreement asset within the specified date range will be returned. If false, all events will be returned | [optional] 
**FilterEvents** | **List&lt;string&gt;** | If filterEvents are specified, only those event types will be returned. If filterEvents are not specified, all event types will be returned.The Agreement Event type should be given in form of array like [\&quot;ESIGNED\&quot;,\&quot;SIGNED\&quot;] | [optional] 
**StartDate** | **DateTime?** | The beginning of the date range for which events will be returned. Date should be mentioned in YYYY-MM-DDTHH:MM:SS format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

