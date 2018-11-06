# IO.Swagger.Model.WidgetCreationInfoV6
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalParticipantSetsInfo** | [**List&lt;WidgetAdditionalParticipationSetInfo&gt;**](WidgetAdditionalParticipationSetInfo.md) | List of all the participants in the widget except widget signer | [optional] 
**CreatorEmail** | **string** | Email of widget creator. Only returned in GET response. Cannot be provided in POST/PUT request. If provided in POST, it will simply be ignored | [optional] 
**Locale** | **string** | The locale associated with this widget - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the widget creator | [optional] 
**VaultingInfo** | [**VaultingInfo**](VaultingInfo.md) | Vaulting properties that allows Adobe Sign to securely store documents with a vault provider | [optional] 
**SecurityOption** | [**SecurityOption**](SecurityOption.md) | Secondary security parameters for the widget | [optional] 
**WidgetParticipantSetInfo** | [**WidgetParticipantSetInfo**](WidgetParticipantSetInfo.md) | Represents widget participant for whom email should not be provided | [optional] 
**Ccs** | [**List&lt;WidgetCcInfo&gt;**](WidgetCcInfo.md) | A list of one or more email addresses that you want to copy on this transaction. The email addresses will each receive an email when the final agreement created through widget is signed. The email addresses will also receive a copy of the document, attached as a PDF file | [optional] 
**CreatedDate** | **DateTime?** | Date when widget was created. If provided in POST, it will simply be ignored. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time | [optional] 
**Name** | **string** | The name of the widget that will be used to identify it, in emails, website and other places | [optional] 
**CompletionInfo** | [**WidgetRedirectionInfo**](WidgetRedirectionInfo.md) | URL and associated properties for the success page the widget signer will be taken to after performing desired action on the widget | [optional] 
**AuthFailureInfo** | [**WidgetRedirectionInfo**](WidgetRedirectionInfo.md) | URL and associated properties for the error page the widget signer will be taken after failing to authenticate | [optional] 
**FileInfos** | [**List&lt;FileInfo&gt;**](FileInfo.md) | A list of one or more files (or references to files) that will be used to create the widget. If more than one file is provided, they will be combined before the widget is created. Library documents are not permitted. Note: Only one of the four parameters in every FileInfo object must be specified | [optional] 
**Id** | **string** | A resource identifier that can be used to uniquely identify the widget in other apis. If provided in POST, it will simply be ignored | [optional] 
**State** | **string** | The state in which the widget should land. For example in order to create a widget in DRAFT state, field should be DRAFT. The state field will never get returned in GET /widgets/{ID} and will be ignored if provided in PUT /widgets/{ID} call. The eventual status of the widget can be obtained from GET /widgets/ID | [optional] 
**Status** | **string** | Status of the Widget. If provided in POST, it will simply be ignored | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

