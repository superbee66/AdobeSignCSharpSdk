# IO.Swagger.Model.AgreementAssetEventPostResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SearchId** | **string** | The search Id corresponding to current search object. This searchId can be used in combination with pageCursors retrieved from the API which retrieves agreementAssetEvents based on a searchId, to fetch the result for further pages | [optional] 
**NextPageCursor** | **string** | The page cursor of the next page to be fetched. If the next page cursor is blank then the given page is the last page | [optional] 
**CurrentPageCursor** | **string** | The value of the page cursor corresponding to the current page | [optional] 
**Events** | [**List&lt;DocumentEventForUser&gt;**](DocumentEventForUser.md) | An ordered list of the events in the audit trail of this document | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

