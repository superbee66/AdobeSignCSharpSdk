using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class DocumentImageUrlsInfo
    {
        /// <summary>
        ///     Id of the document
        /// </summary>
        /// <value>Id of the document</value>
        [DataMember(Name = "documentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "documentId")]
        public string DocumentId { get; set; }

        /// <summary>
        ///     A list of documents image URLs.
        /// </summary>
        /// <value>A list of documents image URLs.</value>
        [DataMember(Name = "documentImageUrlsList", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "documentImageUrlsList")]
        public List<DocumentImageUrls> DocumentImageUrlsList { get; set; }

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
            sb.Append("class DocumentImageUrlsInfo {\n");
            sb.Append("  DocumentImageUrlsList: ").Append(DocumentImageUrlsList).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}