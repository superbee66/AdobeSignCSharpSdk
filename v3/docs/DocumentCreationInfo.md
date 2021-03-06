# IO.Swagger.Model.DocumentCreationInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MergeFieldInfo** | [**List&lt;MergefieldInfo&gt;**](MergefieldInfo.md) | Optional default values for fields to merge into the document. The values will be presented to the signers for editable fields; for read-only fields the provided values will not be editable during the signing process. Merging data into fields is currently not supported when used with libraryDocumentId or libraryDocumentName. Only file and url are currently supported | [optional] 
**CallbackInfo** | **string** | A publicly accessible url to which Adobe Sign will do an HTTP GET operation every time there is a new agreement event. HTTP authentication is supported using standard embedded syntax - i.e. http://username:password@your.server.com/path/to/file. Adobe Sign can also ping your system using HTTP PUT with the final signed PDF. Please contact support@echosign.com if you wish to use this option. | [optional] 
**Locale** | **string** | The locale associated with this agreement - specifies the language for the signing page and emails, for example en_US or fr_FR.  If none specified, defaults to the language configured for the agreement sender | [optional] 
**Message** | **string** | An optional message to the recipients, describing what is being sent or why their signature is required | [optional] 
**SecurityOptions** | [**SecurityOption**](SecurityOption.md) | Sets optional secondary security parameters for your document | [optional] 
**VaultingInfo** | [**VaultingInfo**](VaultingInfo.md) | Sets the vaulting properties that allows Adobe Sign to securely store documents with a vault provider | [optional] 
**ReminderFrequency** | **string** | Optional parameter that sets how often you want to send reminders to the recipients. The possible values are DAILY_UNTIL_SIGNED, WEEKDAILY_UNTIL_SIGNED, EVERY_OTHER_DAY_UNTIL_SIGNED, EVERY_THIRD_DAY_UNTIL_SIGNED, EVERY_FIFTH_DAY_UNTIL_SIGNED, WEEKLY_UNTIL_SIGNED | [optional] 
**Ccs** | [**List&lt;CcsInfo&gt;**](CcsInfo.md) | A list of one or more email addresses that you want to copy on this transaction. The email addresses will each receive an email at the beginning of the transaction and also when the final document is signed. The email addresses will also receive a copy of the document, attached as a PDF file | [optional] 
**PostSignOptions** | [**PostSignOptions**](PostSignOptions.md) | URL and associated properties for the success page the user will be taken to after completing the signing process | [optional] 
**RecipientsListInfo** | [**List&lt;RecipientsInfo&gt;**](RecipientsInfo.md) | A list of one or more recipients. For regular (non-MegaSign) documents, there is no limit on the number of electronic signatures in a single document. Written signatures are limited to four per document. This limit includes the sender if the signature of the sender is also required | [optional] 
**DaysUntilSigningDeadline** | **int?** | The number of days that remain before the document expires. You cannot sign the document after it expires | [optional] 
**FormFieldLayerTemplates** | [**List&lt;FileInfo&gt;**](FileInfo.md) | Specifies the form field layer template or source of form fields to apply on the files in this transaction. If specified, the FileInfo for this parameter must refer to a form field layer template via libraryDocumentId or libraryDocumentName, or if specified via transientDocumentId or documentURL, it must be of a supported file type. Note: Only one of the four parameters in every FileInfo object must be specified | [optional] 
**Name** | **string** | The name of the agreement that will be used to identify it, in emails and on the website | [optional] 
**FileInfos** | [**List&lt;CustomWorkflowFileInfo&gt;**](CustomWorkflowFileInfo.md) | A list of one or more files (or references to files) that will be sent out for signature. If more than one file is provided, they will be combined into one PDF before being sent out. Note: Only one of the four parameters in every FileInfo object must be specified | [optional] 
**FormFields** | [**List&lt;WorkflowBasedFormField&gt;**](WorkflowBasedFormField.md) | Information of form fields of an agreement. PDF_SIGNATURE inputType field is currently not supported. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

