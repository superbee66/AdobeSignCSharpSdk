using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class DocumentCreationInfo
    {
        /// <summary>
        ///     A publicly accessible url to which Adobe Sign will do an HTTP GET operation every time there is a new agreement
        ///     event. HTTP authentication is supported using standard embedded syntax - i.e.
        ///     http://username:password@your.server.com/path/to/file. Adobe Sign can also ping your system using HTTP PUT with the
        ///     final signed PDF. Please contact support@echosign.com if you wish to use this option.
        /// </summary>
        /// <value>
        ///     A publicly accessible url to which Adobe Sign will do an HTTP GET operation every time there is a new agreement
        ///     event. HTTP authentication is supported using standard embedded syntax - i.e.
        ///     http://username:password@your.server.com/path/to/file. Adobe Sign can also ping your system using HTTP PUT with the
        ///     final signed PDF. Please contact support@echosign.com if you wish to use this option.
        /// </value>
        [DataMember(Name = "callbackInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "callbackInfo")]
        public string CallbackInfo { get; set; }

        /// <summary>
        ///     A list of one or more email addresses that you want to copy on this transaction. The email addresses will each
        ///     receive an email at the beginning of the transaction and also when the final document is signed. The email
        ///     addresses will also receive a copy of the document, attached as a PDF file
        /// </summary>
        /// <value>
        ///     A list of one or more email addresses that you want to copy on this transaction. The email addresses will each
        ///     receive an email at the beginning of the transaction and also when the final document is signed. The email
        ///     addresses will also receive a copy of the document, attached as a PDF file
        /// </value>
        [DataMember(Name = "ccs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ccs")]
        public List<CcsInfo> Ccs { get; set; }

        /// <summary>
        ///     The number of days that remain before the document expires. You cannot sign the document after it expires
        /// </summary>
        /// <value>The number of days that remain before the document expires. You cannot sign the document after it expires</value>
        [DataMember(Name = "daysUntilSigningDeadline", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "daysUntilSigningDeadline")]
        public int? DaysUntilSigningDeadline { get; set; }

        /// <summary>
        ///     A list of one or more files (or references to files) that will be sent out for signature. If more than one file is
        ///     provided, they will be combined into one PDF before being sent out. Note: Only one of the four parameters in every
        ///     FileInfo object must be specified
        /// </summary>
        /// <value>
        ///     A list of one or more files (or references to files) that will be sent out for signature. If more than one file
        ///     is provided, they will be combined into one PDF before being sent out. Note: Only one of the four parameters in
        ///     every FileInfo object must be specified
        /// </value>
        [DataMember(Name = "fileInfos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fileInfos")]
        public List<CustomWorkflowFileInfo> FileInfos { get; set; }

        /// <summary>
        ///     Specifies the form field layer template or source of form fields to apply on the files in this transaction. If
        ///     specified, the FileInfo for this parameter must refer to a form field layer template via libraryDocumentId or
        ///     libraryDocumentName, or if specified via transientDocumentId or documentURL, it must be of a supported file type.
        ///     Note: Only one of the four parameters in every FileInfo object must be specified
        /// </summary>
        /// <value>
        ///     Specifies the form field layer template or source of form fields to apply on the files in this transaction. If
        ///     specified, the FileInfo for this parameter must refer to a form field layer template via libraryDocumentId or
        ///     libraryDocumentName, or if specified via transientDocumentId or documentURL, it must be of a supported file type.
        ///     Note: Only one of the four parameters in every FileInfo object must be specified
        /// </value>
        [DataMember(Name = "formFieldLayerTemplates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "formFieldLayerTemplates")]
        public List<FileInfo> FormFieldLayerTemplates { get; set; }

        /// <summary>
        ///     Information of form fields of an agreement. PDF_SIGNATURE inputType field is currently not supported.
        /// </summary>
        /// <value>Information of form fields of an agreement. PDF_SIGNATURE inputType field is currently not supported.</value>
        [DataMember(Name = "formFields", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "formFields")]
        public List<WorkflowBasedFormField> FormFields { get; set; }

        /// <summary>
        ///     The locale associated with this agreement - specifies the language for the signing page and emails, for example
        ///     en_US or fr_FR.  If none specified, defaults to the language configured for the agreement sender
        /// </summary>
        /// <value>
        ///     The locale associated with this agreement - specifies the language for the signing page and emails, for example
        ///     en_US or fr_FR.  If none specified, defaults to the language configured for the agreement sender
        /// </value>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        ///     Optional default values for fields to merge into the document. The values will be presented to the signers for
        ///     editable fields; for read-only fields the provided values will not be editable during the signing process. Merging
        ///     data into fields is currently not supported when used with libraryDocumentId or libraryDocumentName. Only file and
        ///     url are currently supported
        /// </summary>
        /// <value>
        ///     Optional default values for fields to merge into the document. The values will be presented to the signers for
        ///     editable fields; for read-only fields the provided values will not be editable during the signing process. Merging
        ///     data into fields is currently not supported when used with libraryDocumentId or libraryDocumentName. Only file and
        ///     url are currently supported
        /// </value>
        [DataMember(Name = "mergeFieldInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mergeFieldInfo")]
        public List<MergefieldInfo> MergeFieldInfo { get; set; }

        /// <summary>
        ///     An optional message to the recipients, describing what is being sent or why their signature is required
        /// </summary>
        /// <value>An optional message to the recipients, describing what is being sent or why their signature is required</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        ///     The name of the agreement that will be used to identify it, in emails and on the website
        /// </summary>
        /// <value>The name of the agreement that will be used to identify it, in emails and on the website</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     URL and associated properties for the success page the user will be taken to after completing the signing process
        /// </summary>
        /// <value>
        ///     URL and associated properties for the success page the user will be taken to after completing the signing
        ///     process
        /// </value>
        [DataMember(Name = "postSignOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "postSignOptions")]
        public PostSignOptions PostSignOptions { get; set; }

        /// <summary>
        ///     A list of one or more recipients. For regular (non-MegaSign) documents, there is no limit on the number of
        ///     electronic signatures in a single document. Written signatures are limited to four per document. This limit
        ///     includes the sender if the signature of the sender is also required
        /// </summary>
        /// <value>
        ///     A list of one or more recipients. For regular (non-MegaSign) documents, there is no limit on the number of
        ///     electronic signatures in a single document. Written signatures are limited to four per document. This limit
        ///     includes the sender if the signature of the sender is also required
        /// </value>
        [DataMember(Name = "recipientsListInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recipientsListInfo")]
        public List<RecipientsInfo> RecipientsListInfo { get; set; }

        /// <summary>
        ///     Optional parameter that sets how often you want to send reminders to the recipients. The possible values are
        ///     DAILY_UNTIL_SIGNED, WEEKDAILY_UNTIL_SIGNED, EVERY_OTHER_DAY_UNTIL_SIGNED, EVERY_THIRD_DAY_UNTIL_SIGNED,
        ///     EVERY_FIFTH_DAY_UNTIL_SIGNED, WEEKLY_UNTIL_SIGNED
        /// </summary>
        /// <value>
        ///     Optional parameter that sets how often you want to send reminders to the recipients. The possible values are
        ///     DAILY_UNTIL_SIGNED, WEEKDAILY_UNTIL_SIGNED, EVERY_OTHER_DAY_UNTIL_SIGNED, EVERY_THIRD_DAY_UNTIL_SIGNED,
        ///     EVERY_FIFTH_DAY_UNTIL_SIGNED, WEEKLY_UNTIL_SIGNED
        /// </value>
        [DataMember(Name = "reminderFrequency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reminderFrequency")]
        public string ReminderFrequency { get; set; }

        /// <summary>
        ///     Sets optional secondary security parameters for your document
        /// </summary>
        /// <value>Sets optional secondary security parameters for your document</value>
        [DataMember(Name = "securityOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "securityOptions")]
        public SecurityOption SecurityOptions { get; set; }

        /// <summary>
        ///     Sets the vaulting properties that allows Adobe Sign to securely store documents with a vault provider
        /// </summary>
        /// <value>Sets the vaulting properties that allows Adobe Sign to securely store documents with a vault provider</value>
        [DataMember(Name = "vaultingInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vaultingInfo")]
        public VaultingInfo VaultingInfo { get; set; }

        /// <summary>
        ///     Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);


        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentCreationInfo {\n");
            sb.Append("  MergeFieldInfo: ").Append(MergeFieldInfo).Append("\n");
            sb.Append("  CallbackInfo: ").Append(CallbackInfo).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
            sb.Append("  VaultingInfo: ").Append(VaultingInfo).Append("\n");
            sb.Append("  ReminderFrequency: ").Append(ReminderFrequency).Append("\n");
            sb.Append("  Ccs: ").Append(Ccs).Append("\n");
            sb.Append("  PostSignOptions: ").Append(PostSignOptions).Append("\n");
            sb.Append("  RecipientsListInfo: ").Append(RecipientsListInfo).Append("\n");
            sb.Append("  DaysUntilSigningDeadline: ").Append(DaysUntilSigningDeadline).Append("\n");
            sb.Append("  FormFieldLayerTemplates: ").Append(FormFieldLayerTemplates).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FileInfos: ").Append(FileInfos).Append("\n");
            sb.Append("  FormFields: ").Append(FormFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}