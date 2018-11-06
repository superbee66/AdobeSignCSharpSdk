using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V3.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class DocumentImageUrl
    {
        /// <summary>
        ///     A list of objects representing all image URLs.(one per imagesize).
        /// </summary>
        /// <value>A list of objects representing all image URLs.(one per imagesize).</value>
        [DataMember(Name = "imageUrls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imageUrls")]
        public List<ImageUrl> ImageUrls { get; set; }

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
            sb.Append("class DocumentImageUrl {\n");
            sb.Append("  ImageUrls: ").Append(ImageUrls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}