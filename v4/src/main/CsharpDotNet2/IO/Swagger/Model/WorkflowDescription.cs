using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WorkflowDescription
    {
        /// <summary>
        ///     Information about name field in DocumentCreationInfo input field in the agreement creation request when using the
        ///     API which creates an agreement in a workflow
        /// </summary>
        /// <value>
        ///     Information about name field in DocumentCreationInfo input field in the agreement creation request when using
        ///     the API which creates an agreement in a workflow
        /// </value>
        [DataMember(Name = "agreementNameInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "agreementNameInfo")]
        public WorkflowDefaultParams AgreementNameInfo { get; set; }

        /// <summary>
        ///     Information about authoringRequested field in SendDocumentInteractiveOptions input field in the agreement creation
        ///     request when using the API which creates an agreement in a workflow
        /// </summary>
        /// <value>
        ///     Information about authoringRequested field in SendDocumentInteractiveOptions input field in the agreement
        ///     creation request when using the API which creates an agreement in a workflow
        /// </value>
        [DataMember(Name = "authoringInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "authoringInfo")]
        public WorkflowDefaultParams AuthoringInfo { get; set; }

        /// <summary>
        ///     Information about CCList input field in the agreement creation request when using the API which creates an
        ///     agreement in a workflow
        /// </summary>
        /// <value>
        ///     Information about CCList input field in the agreement creation request when using the API which creates an
        ///     agreement in a workflow
        /// </value>
        [DataMember(Name = "ccsListInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ccsListInfo")]
        public List<CCsListInfoDescription> CcsListInfo { get; set; }

        /// <summary>
        ///     The day on which the workflow was created
        /// </summary>
        /// <value>The day on which the workflow was created</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "created")]
        public DateTime? Created { get; set; }

        /// <summary>
        ///     Description provided for this workflow at the time of its creation
        /// </summary>
        /// <value>Description provided for this workflow at the time of its creation</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        ///     The display name of the workflow.
        /// </summary>
        /// <value>The display name of the workflow.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Information about daysUntilSigningDeadline field in DocumentCreationInfo input field in the agreement creation
        ///     request when using the API which creates an agreement in a workflow
        /// </summary>
        /// <value>
        ///     Information about daysUntilSigningDeadline field in DocumentCreationInfo input field in the agreement creation
        ///     request when using the API which creates an agreement in a workflow
        /// </value>
        [DataMember(Name = "expirationInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expirationInfo")]
        public ExpirationFieldInfoDescription ExpirationInfo { get; set; }

        /// <summary>
        ///     Information about FileInfo input field in the agreement creation request when using the API which creates an
        ///     agreement in a workflow
        /// </summary>
        /// <value>
        ///     Information about FileInfo input field in the agreement creation request when using the API which creates an
        ///     agreement in a workflow
        /// </value>
        [DataMember(Name = "fileInfos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fileInfos")]
        public List<FileInfosDescription> FileInfos { get; set; }

        /// <summary>
        ///     Information about locale  field in DocumentCreationInfo input field in the agreement creation request when using
        ///     the API which creates an agreement in a workflow
        /// </summary>
        /// <value>
        ///     Information about locale  field in DocumentCreationInfo input field in the agreement creation request when using
        ///     the API which creates an agreement in a workflow
        /// </value>
        [DataMember(Name = "localeInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "localeInfo")]
        public LocaleFieldInfoDescription LocaleInfo { get; set; }

        /// <summary>
        ///     Information about customFieldInfos in DocumentCreationInfo input field in the agreement creation request when using
        ///     the API which creates an agreement in a workflow
        /// </summary>
        /// <value>
        ///     Information about customFieldInfos in DocumentCreationInfo input field in the agreement creation request when
        ///     using the API which creates an agreement in a workflow
        /// </value>
        [DataMember(Name = "mergeFieldsInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mergeFieldsInfo")]
        public List<MergeFieldInfoDescription> MergeFieldsInfo { get; set; }

        /// <summary>
        ///     Information about message field in DocumentCreationInfo input field in the agreement creation request when using
        ///     the API which creates an agreement in a workflow
        /// </summary>
        /// <value>
        ///     Information about message field in DocumentCreationInfo input field in the agreement creation request when using
        ///     the API which creates an agreement in a workflow
        /// </value>
        [DataMember(Name = "messageInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "messageInfo")]
        public WorkflowDefaultParams MessageInfo { get; set; }

        /// <summary>
        ///     The day on which the workflow was last modified
        /// </summary>
        /// <value>The day on which the workflow was last modified</value>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        ///     The name of the workflow.
        /// </summary>
        /// <value>The name of the workflow.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Information about openPassword field in SecurityOptions input field in the agreement creation request when using
        ///     the API which creates an agreement in a workflow
        /// </summary>
        /// <value>
        ///     Information about openPassword field in SecurityOptions input field in the agreement creation request when using
        ///     the API which creates an agreement in a workflow
        /// </value>
        [DataMember(Name = "passwordInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "passwordInfo")]
        public PasswordFieldInfoDescription PasswordInfo { get; set; }

        /// <summary>
        ///     Information about RecepientsInfo input field in the agreement creation request when using the API which creates an
        ///     agreement in a workflow
        /// </summary>
        /// <value>
        ///     Information about RecepientsInfo input field in the agreement creation request when using the API which creates
        ///     an agreement in a workflow
        /// </value>
        [DataMember(Name = "recipientsListInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recipientsListInfo")]
        public List<RecipientsListInfoDescription> RecipientsListInfo { get; set; }

        /// <summary>
        ///     The workflow scope (ACCOUNT or GROUP or OTHER)
        /// </summary>
        /// <value>The workflow scope (ACCOUNT or GROUP or OTHER)</value>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        ///     Identifier of scope. Currently it is applicable for scope GROUP only and the value will be groupId.
        /// </summary>
        /// <value>Identifier of scope. Currently it is applicable for scope GROUP only and the value will be groupId.</value>
        [DataMember(Name = "scopeId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scopeId")]
        public string ScopeId { get; set; }

        /// <summary>
        ///     The workflow status (ACTIVE or DRAFT or INACTIVE or OTHER)
        /// </summary>
        /// <value>The workflow status (ACTIVE or DRAFT or INACTIVE or OTHER)</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

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
            sb.Append("class WorkflowDescription {\n");
            sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  MessageInfo: ").Append(MessageInfo).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MergeFieldsInfo: ").Append(MergeFieldsInfo).Append("\n");
            sb.Append("  AgreementNameInfo: ").Append(AgreementNameInfo).Append("\n");
            sb.Append("  PasswordInfo: ").Append(PasswordInfo).Append("\n");
            sb.Append("  AuthoringInfo: ").Append(AuthoringInfo).Append("\n");
            sb.Append("  RecipientsListInfo: ").Append(RecipientsListInfo).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ExpirationInfo: ").Append(ExpirationInfo).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  FileInfos: ").Append(FileInfos).Append("\n");
            sb.Append("  LocaleInfo: ").Append(LocaleInfo).Append("\n");
            sb.Append("  CcsListInfo: ").Append(CcsListInfo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}