using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V5.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class AgreementInfo
    {
        /// <summary>
        ///     A resource identifier that can be used to uniquely identify the agreement resource in other apis
        /// </summary>
        /// <value>A resource identifier that can be used to uniquely identify the agreement resource in other apis</value>
        [DataMember(Name = "agreementId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "agreementId")]
        public string AgreementId { get; set; }

        /// <summary>
        ///     An ordered list of the events in the audit trail of this document
        /// </summary>
        /// <value>An ordered list of the events in the audit trail of this document</value>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "events")]
        public List<DocumentHistoryEvent> Events { get; set; }

        /// <summary>
        ///     The date after which the document can no longer be signed, if an expiration date is configured. The value is nil if
        ///     an expiration date is not set for the document
        /// </summary>
        /// <value>
        ///     The date after which the document can no longer be signed, if an expiration date is configured. The value is nil
        ///     if an expiration date is not set for the document
        /// </value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expiration")]
        public DateTime? Expiration { get; set; }

        /// <summary>
        ///     An arbitrary value from your system, which can be specified at sending time and then later returned or queried
        /// </summary>
        /// <value>An arbitrary value from your system, which can be specified at sending time and then later returned or queried</value>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "externalId")]
        public ExternalId ExternalId { get; set; }

        /// <summary>
        ///     An ID which uniquely identifies the current version of the document
        /// </summary>
        /// <value>An ID which uniquely identifies the current version of the document</value>
        [DataMember(Name = "latestVersionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "latestVersionId")]
        public string LatestVersionId { get; set; }

        /// <summary>
        ///     The locale associated with this agreement - for example, en_US or fr_FR
        /// </summary>
        /// <value>The locale associated with this agreement - for example, en_US or fr_FR</value>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        ///     The message associated with the document that the sender has provided
        /// </summary>
        /// <value>The message associated with the document that the sender has provided</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        ///     Information about whether the agreement can be modified
        /// </summary>
        /// <value>Information about whether the agreement can be modified</value>
        [DataMember(Name = "modifiable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modifiable")]
        public bool? Modifiable { get; set; }

        /// <summary>
        ///     The name of the document, specified by the sender
        /// </summary>
        /// <value>The name of the document, specified by the sender</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Information about who needs to act next for this document - for example, if the agreement is in status
        ///     OUT_FOR_SIGNATURE or OUT_FOR_APPROVAL, this will be the next signer or approver. If the AgreementStatus is a
        ///     terminal state, this array is empty
        /// </summary>
        /// <value>
        ///     Information about who needs to act next for this document - for example, if the agreement is in status
        ///     OUT_FOR_SIGNATURE or OUT_FOR_APPROVAL, this will be the next signer or approver. If the AgreementStatus is a
        ///     terminal state, this array is empty
        /// </value>
        [DataMember(Name = "nextParticipantSetInfos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nextParticipantSetInfos")]
        public List<NextParticipantSetInfo> NextParticipantSetInfos { get; set; }

        /// <summary>
        ///     Information about all the participant sets of this document
        /// </summary>
        /// <value>Information about all the participant sets of this document</value>
        [DataMember(Name = "participantSetInfos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "participantSetInfos")]
        public List<ParticipantSetInfo> ParticipantSetInfos { get; set; }

        /// <summary>
        ///     Security information about the document that specifies whether or not a password is required to view and sign the
        ///     document
        /// </summary>
        /// <value>
        ///     Security information about the document that specifies whether or not a password is required to view and sign
        ///     the document
        /// </value>
        [DataMember(Name = "securityOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "securityOptions")]
        public List<string> SecurityOptions { get; set; }

        /// <summary>
        ///     Specifies the type of signature you would like to request - written or e-signature. The possible values are
        ///     <br>
        ///         ESIGN : Agreement needs to be signed electronically
        ///         <br>
        ///             , WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into
        ///             the system
        /// </summary>
        /// <value>
        ///     Specifies the type of signature you would like to request - written or e-signature. The possible values are
        ///     <br>
        ///         ESIGN : Agreement needs to be signed electronically
        ///         <br>
        ///             , WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into
        ///             the system
        /// </value>
        [DataMember(Name = "signatureType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "signatureType")]
        public string SignatureType { get; set; }

        /// <summary>
        ///     The current status of the document
        /// </summary>
        /// <value>The current status of the document</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        ///     Whether vaulting was enabled for the agreement
        /// </summary>
        /// <value>Whether vaulting was enabled for the agreement</value>
        [DataMember(Name = "vaultingEnabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vaultingEnabled")]
        public bool? VaultingEnabled { get; set; }

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
            sb.Append("class AgreementInfo {\n");
            sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  LatestVersionId: ").Append(LatestVersionId).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SecurityOptions: ").Append(SecurityOptions).Append("\n");
            sb.Append("  NextParticipantSetInfos: ").Append(NextParticipantSetInfos).Append("\n");
            sb.Append("  ParticipantSetInfos: ").Append(ParticipantSetInfos).Append("\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VaultingEnabled: ").Append(VaultingEnabled).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Modifiable: ").Append(Modifiable).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}