using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WidgetCreationInfo
    {
        /// <summary>
        ///     Indicates that authoring is requested prior to sending the document
        /// </summary>
        /// <value>Indicates that authoring is requested prior to sending the document</value>
        [DataMember(Name = "authoringRequested", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "authoringRequested")]
        public bool? AuthoringRequested { get; set; }

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
        ///     receive an email when the final agreement created through widget is signed. The email addresses will also receive a
        ///     copy of the document, attached as a PDF file.
        /// </summary>
        /// <value>
        ///     A list of one or more email addresses that you want to copy on this transaction. The email addresses will each
        ///     receive an email when the final agreement created through widget is signed. The email addresses will also receive a
        ///     copy of the document, attached as a PDF file.
        /// </value>
        [DataMember(Name = "ccs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ccs")]
        public List<string> Ccs { get; set; }

        /// <summary>
        ///     A list of one or more counter signers provided in the form of counter signer set.
        /// </summary>
        /// <value>A list of one or more counter signers provided in the form of counter signer set.</value>
        [DataMember(Name = "counterSignerSetInfos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "counterSignerSetInfos")]
        public List<CounterSignerSetInfo> CounterSignerSetInfos { get; set; }

        /// <summary>
        ///     A list of one or more files (or references to files) that will be used to create the widget. If more than one file
        ///     is provided, they will be combined before the widget is created. Library documents are not permitted. Note: Only
        ///     one of the four parameters in every FileInfo object must be specified
        /// </summary>
        /// <value>
        ///     A list of one or more files (or references to files) that will be used to create the widget. If more than one
        ///     file is provided, they will be combined before the widget is created. Library documents are not permitted. Note:
        ///     Only one of the four parameters in every FileInfo object must be specified
        /// </value>
        [DataMember(Name = "fileInfos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fileInfos")]
        public List<WidgetFileInfo> FileInfos { get; set; }

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
        public List<WidgetFileInfo> FormFieldLayerTemplates { get; set; }

        /// <summary>
        ///     The locale associated with this widget - specifies the language for the signing page and emails, for example en_US
        ///     or fr_FR.  If none specified, defaults to the language configured for the widget creator
        /// </summary>
        /// <value>
        ///     The locale associated with this widget - specifies the language for the signing page and emails, for example
        ///     en_US or fr_FR.  If none specified, defaults to the language configured for the widget creator
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
        public List<WidgetMergefieldInfo> MergeFieldInfo { get; set; }

        /// <summary>
        ///     The name of the widget that will be used to identify it, in emails and on the website
        /// </summary>
        /// <value>The name of the widget that will be used to identify it, in emails and on the website</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Role of the first participant of widget
        /// </summary>
        /// <value>Role of the first participant of widget</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        ///     Sets optional secondary security parameters for your widget
        /// </summary>
        /// <value>Sets optional secondary security parameters for your widget</value>
        [DataMember(Name = "securityOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "securityOptions")]
        public WidgetSecurityOption SecurityOptions { get; set; }

        /// <summary>
        ///     Selects the workflow you would like to use - whether the sender needs to sign before the recipient, after the
        ///     recipient, or not at all. The possible values for this variable are SENDER_SIGNATURE_NOT_REQUIRED or
        ///     SENDER_SIGNS_LAST
        /// </summary>
        /// <value>
        ///     Selects the workflow you would like to use - whether the sender needs to sign before the recipient, after the
        ///     recipient, or not at all. The possible values for this variable are SENDER_SIGNATURE_NOT_REQUIRED or
        ///     SENDER_SIGNS_LAST
        /// </value>
        [DataMember(Name = "signatureFlow", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "signatureFlow")]
        public string SignatureFlow { get; set; }

        /// <summary>
        ///     Sets the vaulting properties that allows Adobe Sign to securely store documents with a vault provider
        /// </summary>
        /// <value>Sets the vaulting properties that allows Adobe Sign to securely store documents with a vault provider</value>
        [DataMember(Name = "vaultingInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vaultingInfo")]
        public WidgetVaultingInfo VaultingInfo { get; set; }

        /// <summary>
        ///     URL and associated properties for the error page the user will be taken after failing to authenticate
        /// </summary>
        /// <value>URL and associated properties for the error page the user will be taken after failing to authenticate</value>
        [DataMember(Name = "widgetAuthFailureInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "widgetAuthFailureInfo")]
        public WidgetCompletionInfo WidgetAuthFailureInfo { get; set; }

        /// <summary>
        ///     URL and associated properties for the success page the user will be taken to after filling out the widget
        /// </summary>
        /// <value>URL and associated properties for the success page the user will be taken to after filling out the widget</value>
        [DataMember(Name = "widgetCompletionInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "widgetCompletionInfo")]
        public WidgetCompletionInfo WidgetCompletionInfo { get; set; }

        /// <summary>
        ///     Security options that apply to widget signers
        /// </summary>
        /// <value>Security options that apply to widget signers</value>
        [DataMember(Name = "widgetSignerSecurityOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "widgetSignerSecurityOptions")]
        public WidgetSignerSecurityOption WidgetSignerSecurityOptions { get; set; }

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
            sb.Append("class WidgetCreationInfo {\n");
            sb.Append("  MergeFieldInfo: ").Append(MergeFieldInfo).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  CallbackInfo: ").Append(CallbackInfo).Append("\n");
            sb.Append("  WidgetCompletionInfo: ").Append(WidgetCompletionInfo).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
            sb.Append("  VaultingInfo: ").Append(VaultingInfo).Append("\n");
            sb.Append("  AuthoringRequested: ").Append(AuthoringRequested).Append("\n");
            sb.Append("  Ccs: ").Append(Ccs).Append("\n");
            sb.Append("  SignatureFlow: ").Append(SignatureFlow).Append("\n");
            sb.Append("  FormFieldLayerTemplates: ").Append(FormFieldLayerTemplates).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CounterSignerSetInfos: ").Append(CounterSignerSetInfos).Append("\n");
            sb.Append("  WidgetAuthFailureInfo: ").Append(WidgetAuthFailureInfo).Append("\n");
            sb.Append("  FileInfos: ").Append(FileInfos).Append("\n");
            sb.Append("  WidgetSignerSecurityOptions: ").Append(WidgetSignerSecurityOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}