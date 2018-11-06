using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class CustomWorkflowAgreementCreationRequest
    {
        /// <summary>
        ///     Information about the document you want to send
        /// </summary>
        /// <value>Information about the document you want to send</value>
        [DataMember(Name = "documentCreationInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "documentCreationInfo")]
        public DocumentCreationInfo DocumentCreationInfo { get; set; }

        /// <summary>
        ///     Options for authoring and sending the agreement
        /// </summary>
        /// <value>Options for authoring and sending the agreement</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "options")]
        public InteractiveOptions Options { get; set; }

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
            sb.Append("class CustomWorkflowAgreementCreationRequest {\n");
            sb.Append("  DocumentCreationInfo: ").Append(DocumentCreationInfo).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}