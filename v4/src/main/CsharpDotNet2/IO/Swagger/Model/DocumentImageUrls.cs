using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class DocumentImageUrls
    {
        /// <summary>
        ///     A list of documents image URLs.
        /// </summary>
        /// <value>A list of documents image URLs.</value>
        [DataMember(Name = "documentsImageUrls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "documentsImageUrls")]
        public List<DocumentImageUrl> DocumentsImageUrls { get; set; }

        /// <summary>
        ///     A list of supporting document image URLs.
        /// </summary>
        /// <value>A list of supporting document image URLs.</value>
        [DataMember(Name = "supportingDocumentsImageUrls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "supportingDocumentsImageUrls")]
        public List<DocumentImageUrl> SupportingDocumentsImageUrls { get; set; }

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
            sb.Append("class DocumentImageUrls {\n");
            sb.Append("  DocumentsImageUrls: ").Append(DocumentsImageUrls).Append("\n");
            sb.Append("  SupportingDocumentsImageUrls: ").Append(SupportingDocumentsImageUrls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}