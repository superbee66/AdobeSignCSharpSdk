using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V6.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class DocumentsImageUrlsInfo
    {
        /// <summary>
        ///     A list of original document image URLs info.
        /// </summary>
        /// <value>A list of original document image URLs info.</value>
        [DataMember(Name = "originalDocumentsImageUrlsInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "originalDocumentsImageUrlsInfo")]
        public List<DocumentImageUrlsInfo> OriginalDocumentsImageUrlsInfo { get; set; }

        /// <summary>
        ///     A list of supporting document image URLs info.
        /// </summary>
        /// <value>A list of supporting document image URLs info.</value>
        [DataMember(Name = "supportingDocumentsImageUrlsInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "supportingDocumentsImageUrlsInfo")]
        public List<DocumentImageUrlsInfo> SupportingDocumentsImageUrlsInfo { get; set; }

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
            sb.Append("class DocumentsImageUrlsInfo {\n");
            sb.Append("  SupportingDocumentsImageUrlsInfo: ").Append(SupportingDocumentsImageUrlsInfo).Append("\n");
            sb.Append("  OriginalDocumentsImageUrlsInfo: ").Append(OriginalDocumentsImageUrlsInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}