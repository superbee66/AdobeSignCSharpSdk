using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSignClient.V4.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ImageUrl
    {
        /// <summary>
        ///     true if images for the associated image size is available, else false.
        /// </summary>
        /// <value>true if images for the associated image size is available, else false.</value>
        [DataMember(Name = "imagesAvailable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imagesAvailable")]
        public bool? ImagesAvailable { get; set; }

        /// <summary>
        ///     ImageSize corresponding to the imageUrl returned
        /// </summary>
        /// <value>ImageSize corresponding to the imageUrl returned </value>
        [DataMember(Name = "imageSize", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imageSize")]
        public string ImageSize { get; set; }

        /// <summary>
        ///     An ordered list of image urls (one per page).
        /// </summary>
        /// <value>An ordered list of image urls (one per page).</value>
        [DataMember(Name = "urls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "urls")]
        public List<string> Urls { get; set; }

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
            sb.Append("class ImageUrl {\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
            sb.Append("  ImagesAvailable: ").Append(ImagesAvailable).Append("\n");
            sb.Append("  ImageSize: ").Append(ImageSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}