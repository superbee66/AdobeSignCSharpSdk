using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class TransientDocumentResponse
    {
        /// <summary>
        ///     The unique identifier of the uploaded document that can be used in an agreement or a megaSign or widget creation
        ///     call
        /// </summary>
        /// <value>
        ///     The unique identifier of the uploaded document that can be used in an agreement or a megaSign or widget creation
        ///     call
        /// </value>
        [DataMember(Name = "transientDocumentId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transientDocumentId")]
        public string TransientDocumentId { get; set; }

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
            sb.Append("class TransientDocumentResponse {\n");
            sb.Append("  TransientDocumentId: ").Append(TransientDocumentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}