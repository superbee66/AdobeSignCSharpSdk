using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V2.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class WidgetOriginalDocument
    {
        /// <summary>
        ///     Id of the document
        /// </summary>
        /// <value>Id of the document</value>
        [DataMember(Name = "documentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "documentId")]
        public string DocumentId { get; set; }

        /// <summary>
        ///     Mime-type of the document
        /// </summary>
        /// <value>Mime-type of the document</value>
        [DataMember(Name = "mimeType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mimeType")]
        public string MimeType { get; set; }

        /// <summary>
        ///     Name of the document
        /// </summary>
        /// <value>Name of the document</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
            sb.Append("class WidgetOriginalDocument {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}