# IO.Swagger.Model.DocumentCreationInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MergeFieldInfo** | [**List&lt;MergefieldInfo&gt;**](MergefieldInfo.md) | Optional default values for fields to merge into the document. The values will be presented to the signers for editable fields; for read-only fields the provided values will not be editable during the signing process. Merging data into fields is currently not supported when used with libraryDocumentId or libraryDocumentName. Only file and url are currently supported | [optional] 
**CallbackInfo** | **string** | A publicly accessible url to which Adobe Sign will do an HTTP GET operation every time there is a new agreement event. HTTP authentication is supported using standard embedded syntax - i.e. http://username:password@your.server.com/path/to/file. Adobe Sign can also ping your system using HTTP PUT with the final signed PDF. Please contact support@echosign.com if you wish to use this option. | [optional] 
**SignatureType** | **string** | Specifies the type of signature you would like to request - written or e-signature. The possible values are ESIGN or WRITTEN | [optional] 
**Locale** | **string** | The locale associated with this agreement - specifies the language for the signing page and emails, for example en_US or fr_FR.  If none specified, defaults to the language configured for the agreement sender | [optional] 
**Message** | **string** | An optional message to the recipients, describing what is being sent or why their signature is required | [optional] 
**SecurityOptions** | [**SecurityOption**](SecurityOption.md) | Sets optional secondary security parameters for your document | [optional] 
**DocumentURLs** | [**List&lt;URLFileInfo&gt;**](URLFileInfo.md) | Files at a public URL location | [optional] 
**LibraryDocumentNames** | **List&lt;string&gt;** | The name of a library document that is available to the sender. If multiple library documents having the same name exist, the latest one is selected. This can be used to build integrations that allow the contents of the document to be changed, in the future, without any code changes | [optional] 
**ReminderFrequency** | **string** | Optional parameter that sets how often you want to send reminders to the recipients. The possible values are DAILY_UNTIL_SIGNED, WEEKDAILY_UNTIL_SIGNED, EVERY_OTHER_DAY_UNTIL_SIGNED, EVERY_THIRD_DAY_UNTIL_SIGNED, EVERY_FIFTH_DAY_UNTIL_SIGNED, WEEKLY_UNTIL_SIGNED | [optional] 
**Ccs** | **List&lt;string&gt;** | A list of one or more email addresses that you want to copy on this transaction. The email addresses will each receive an email at the beginning of the transaction and also when the final document is signed. The email addresses will also receive a copy of the document, attached as a PDF file | [optional] 
**SignatureFlow** | **string** | Selects the workflow you would like to use - whether the sender needs to sign before the recipient, after the recipient, or not at all. The possible values for this variable are SENDER_SIGNATURE_NOT_REQUIRED, SENDER_SIGNS_LAST, or SENDER_SIGNS_FIRST | [optional] 
**TransientDocumentIds** | **List&lt;string&gt;** | A list of documents associated with this agreement. The documentIDs are returned in the transient document creation API | [optional] 
**DaysUntilSigningDeadline** | **int?** | The number of days that remain before the document expires. You cannot sign the document after it expires | [optional] 
**Recipients** | [**List&lt;RecipientInfo&gt;**](RecipientInfo.md) | A list of one or more recipients. For regular (non-MegaSign) documents, there is no limit on the number of electronic signatures in a single document. Written signatures are limited to four per document. This limit includes the sender if the signature of the sender is also required | [optional] 
**Name** | **string** | The name of the agreement that will be used to identify it, in emails and on the website | [optional] 
**LibraryDocumentIds** | **List&lt;string&gt;** | The ID for a library document that is available to the sender | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

