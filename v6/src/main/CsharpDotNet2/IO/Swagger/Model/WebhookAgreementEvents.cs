using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WebhookAgreementEvents
    {
        /// <summary>
        ///     Determines whether agreement detailed info will be returned in the response payload
        /// </summary>
        /// <value>Determines whether agreement detailed info will be returned in the response payload</value>
        [DataMember(Name = "includeDetailedInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "includeDetailedInfo")]
        public bool? IncludeDetailedInfo { get; set; }

        /// <summary>
        ///     Determines whether document info will be returned in the response payload
        /// </summary>
        /// <value>Determines whether document info will be returned in the response payload</value>
        [DataMember(Name = "includeDocumentsInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "includeDocumentsInfo")]
        public bool? IncludeDocumentsInfo { get; set; }

        /// <summary>
        ///     Determines whether participants info will be returned in the response payload
        /// </summary>
        /// <value>Determines whether participants info will be returned in the response payload</value>
        [DataMember(Name = "includeParticipantsInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "includeParticipantsInfo")]
        public bool? IncludeParticipantsInfo { get; set; }

        /// <summary>
        ///     Determines whether documents will be returned in webhook response payload. If set to true, signed document will be
        ///     returned in base 64 encoded format in JSON when signing is complete
        /// </summary>
        /// <value>
        ///     Determines whether documents will be returned in webhook response payload. If set to true, signed document will
        ///     be returned in base 64 encoded format in JSON when signing is complete
        /// </value>
        [DataMember(Name = "includeSignedDocuments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "includeSignedDocuments")]
        public bool? IncludeSignedDocuments { get; set; }

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
            sb.Append("class WebhookAgreementEvents {\n");
            sb.Append("  IncludeDetailedInfo: ").Append(IncludeDetailedInfo).Append("\n");
            sb.Append("  IncludeParticipantsInfo: ").Append(IncludeParticipantsInfo).Append("\n");
            sb.Append("  IncludeSignedDocuments: ").Append(IncludeSignedDocuments).Append("\n");
            sb.Append("  IncludeDocumentsInfo: ").Append(IncludeDocumentsInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}