# IO.Swagger.Model.InteractiveOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthoringRequested** | **bool?** | Indicates that authoring is requested prior to sending the document | [optional] 
**AutoLoginUser** | **bool?** | If user settings allow, automatically logs the user in | [optional] 
**NoChrome** | **bool?** | Turn off Chrome for the URL generated | [optional] 
**SendThroughWeb** | **bool?** | A url to send page will be returned from where the agreement creation needs to be completed. All the parameters provided here will be retained in the send page | [optional] 
**SendThroughWebOptions** | [**SendThroughWebOptions**](SendThroughWebOptions.md) | A JSON object of Type SendThroughWebOptions to customize the sendPage. This one will apply only if sendThroughWeb is set to true | [optional] 
**Locale** | **string** | The locale in which page returned by this API should be shown in - for example, en_US or fr_FR. In case locale provided by client is not available or no locale is specified, page will be shown in the default language set in the user account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

