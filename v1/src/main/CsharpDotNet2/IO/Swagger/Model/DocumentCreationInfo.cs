using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V1.Model
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
        public List<string> Ccs { get; set; }

        /// <summary>
        ///     The number of days that remain before the document expires. You cannot sign the document after it expires
        /// </summary>
        /// <value>The number of days that remain before the document expires. You cannot sign the document after it expires</value>
        [DataMember(Name = "daysUntilSigningDeadline", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "daysUntilSigningDeadline")]
        public int? DaysUntilSigningDeadline { get; set; }

        /// <summary>
        ///     Files at a public URL location
        /// </summary>
        /// <value>Files at a public URL location</value>
        [DataMember(Name = "documentURLs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "documentURLs")]
        public List<URLFileInfo> DocumentURLs { get; set; }

        /// <summary>
        ///     The ID for a library document that is available to the sender
        /// </summary>
        /// <value>The ID for a library document that is available to the sender</value>
        [DataMember(Name = "libraryDocumentIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "libraryDocumentIds")]
        public List<string> LibraryDocumentIds { get; set; }

        /// <summary>
        ///     The name of a library document that is available to the sender. If multiple library documents having the same name
        ///     exist, the latest one is selected. This can be used to build integrations that allow the contents of the document
        ///     to be changed, in the future, without any code changes
        /// </summary>
        /// <value>
        ///     The name of a library document that is available to the sender. If multiple library documents having the same
        ///     name exist, the latest one is selected. This can be used to build integrations that allow the contents of the
        ///     document to be changed, in the future, without any code changes
        /// </value>
        [DataMember(Name = "libraryDocumentNames", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "libraryDocumentNames")]
        public List<string> LibraryDocumentNames { get; set; }

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
        ///     A list of one or more recipients. For regular (non-MegaSign) documents, there is no limit on the number of
        ///     electronic signatures in a single document. Written signatures are limited to four per document. This limit
        ///     includes the sender if the signature of the sender is also required
        /// </summary>
        /// <value>
        ///     A list of one or more recipients. For regular (non-MegaSign) documents, there is no limit on the number of
        ///     electronic signatures in a single document. Written signatures are limited to four per document. This limit
        ///     includes the sender if the signature of the sender is also required
        /// </value>
        [DataMember(Name = "recipients", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recipients")]
        public List<RecipientInfo> Recipients { get; set; }

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
        ///     Selects the workflow you would like to use - whether the sender needs to sign before the recipient, after the
        ///     recipient, or not at all. The possible values for this variable are SENDER_SIGNATURE_NOT_REQUIRED,
        ///     SENDER_SIGNS_LAST, or SENDER_SIGNS_FIRST
        /// </summary>
        /// <value>
        ///     Selects the workflow you would like to use - whether the sender needs to sign before the recipient, after the
        ///     recipient, or not at all. The possible values for this variable are SENDER_SIGNATURE_NOT_REQUIRED,
        ///     SENDER_SIGNS_LAST, or SENDER_SIGNS_FIRST
        /// </value>
        [DataMember(Name = "signatureFlow", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "signatureFlow")]
        public string SignatureFlow { get; set; }

        /// <summary>
        ///     Specifies the type of signature you would like to request - written or e-signature. The possible values are ESIGN
        ///     or WRITTEN
        /// </summary>
        /// <value>
        ///     Specifies the type of signature you would like to request - written or e-signature. The possible values are
        ///     ESIGN or WRITTEN
        /// </value>
        [DataMember(Name = "signatureType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "signatureType")]
        public string SignatureType { get; set; }

        /// <summary>
        ///     A list of documents associated with this agreement. The documentIDs are returned in the transient document creation
        ///     API
        /// </summary>
        /// <value>
        ///     A list of documents associated with this agreement. The documentIDs are returned in the transient document
        ///     creation API
        /// </value>
        [DataMember(Name = "transientDocumentIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transientDocumentIds")]
        public List<string> TransientDocumentIds { get; set; }

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
            sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
            sb.Append("  DocumentURLs: ").Append(DocumentURLs).Append("\n");
            sb.Append("  LibraryDocumentNames: ").Append(LibraryDocumentNames).Append("\n");
            sb.Append("  ReminderFrequency: ").Append(ReminderFrequency).Append("\n");
            sb.Append("  Ccs: ").Append(Ccs).Append("\n");
            sb.Append("  SignatureFlow: ").Append(SignatureFlow).Append("\n");
            sb.Append("  TransientDocumentIds: ").Append(TransientDocumentIds).Append("\n");
            sb.Append("  DaysUntilSigningDeadline: ").Append(DaysUntilSigningDeadline).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LibraryDocumentIds: ").Append(LibraryDocumentIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}