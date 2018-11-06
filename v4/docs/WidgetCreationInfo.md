# IO.Swagger.Model.WidgetCreationInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MergeFieldInfo** | [**List&lt;WidgetMergefieldInfo&gt;**](WidgetMergefieldInfo.md) | Optional default values for fields to merge into the document. The values will be presented to the signers for editable fields; for read-only fields the provided values will not be editable during the signing process. Merging data into fields is currently not supported when used with libraryDocumentId or libraryDocumentName. Only file and url are currently supported | [optional] 
**Role** | **string** | Role of the first participant of widget | [optional] 
**CallbackInfo** | **string** | A publicly accessible url to which Adobe Sign will do an HTTP GET operation every time there is a new agreement event. HTTP authentication is supported using standard embedded syntax - i.e. http://username:password@your.server.com/path/to/file. Adobe Sign can also ping your system using HTTP PUT with the final signed PDF. Please contact support@echosign.com if you wish to use this option. | [optional] 
**WidgetCompletionInfo** | [**WidgetCompletionInfo**](WidgetCompletionInfo.md) | URL and associated properties for the success page the user will be taken to after filling out the widget | [optional] 
**Locale** | **string** | The locale associated with this widget - specifies the language for the signing page and emails, for example en_US or fr_FR.  If none specified, defaults to the language configured for the widget creator | [optional] 
**SecurityOptions** | [**WidgetSecurityOption**](WidgetSecurityOption.md) | Sets optional secondary security parameters for your widget | [optional] 
**VaultingInfo** | [**WidgetVaultingInfo**](WidgetVaultingInfo.md) | Sets the vaulting properties that allows Adobe Sign to securely store documents with a vault provider | [optional] 
**AuthoringRequested** | **bool?** | Indicates that authoring is requested prior to sending the document | [optional] 
**Ccs** | **List&lt;string&gt;** | A list of one or more email addresses that you want to copy on this transaction. The email addresses will each receive an email when the final agreement created through widget is signed. The email addresses will also receive a copy of the document, attached as a PDF file. | [optional] 
**SignatureFlow** | **string** | Selects the workflow you would like to use - whether the sender needs to sign before the recipient, after the recipient, or not at all. The possible values for this variable are SENDER_SIGNATURE_NOT_REQUIRED or SENDER_SIGNS_LAST | [optional] 
**FormFieldLayerTemplates** | [**List&lt;WidgetFileInfo&gt;**](WidgetFileInfo.md) | Specifies the form field layer template or source of form fields to apply on the files in this transaction. If specified, the FileInfo for this parameter must refer to a form field layer template via libraryDocumentId or libraryDocumentName, or if specified via transientDocumentId or documentURL, it must be of a supported file type. Note: Only one of the four parameters in every FileInfo object must be specified | [optional] 
**Name** | **string** | The name of the widget that will be used to identify it, in emails and on the website | [optional] 
**CounterSignerSetInfos** | [**List&lt;CounterSignerSetInfo&gt;**](CounterSignerSetInfo.md) | A list of one or more counter signers provided in the form of counter signer set. | [optional] 
**WidgetAuthFailureInfo** | [**WidgetCompletionInfo**](WidgetCompletionInfo.md) | URL and associated properties for the error page the user will be taken after failing to authenticate | [optional] 
**FileInfos** | [**List&lt;WidgetFileInfo&gt;**](WidgetFileInfo.md) | A list of one or more files (or references to files) that will be used to create the widget. If more than one file is provided, they will be combined before the widget is created. Library documents are not permitted. Note: Only one of the four parameters in every FileInfo object must be specified | [optional] 
**WidgetSignerSecurityOptions** | [**WidgetSignerSecurityOption**](WidgetSignerSecurityOption.md) | Security options that apply to widget signers | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

