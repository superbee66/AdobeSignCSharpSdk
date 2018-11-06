using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V1.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class AgreementDocuments
    {
        /// <summary>
        ///     A list of documents
        /// </summary>
        /// <value>A list of documents</value>
        [DataMember(Name = "documents", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "documents")]
        public List<Document> Documents { get; set; }

        /// <summary>
        ///     A list of supporting documents. This is returned only if there are any supporting document in the agreement
        /// </summary>
        /// <value>A list of supporting documents. This is returned only if there are any supporting document in the agreement</value>
        [DataMember(Name = "supportingDocuments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "supportingDocuments")]
        public List<SupportingDocument> SupportingDocuments { get; set; }

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
            sb.Append("class AgreementDocuments {\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  SupportingDocuments: ").Append(SupportingDocuments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}